using System;
using System.Collections.Generic;
using System.Text;



using System.Collections;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace Lanetor
{

	public class EncryptionThread
	{
		private ContainerControl containerControl = null;
		private Delegate finishedProcessDelegate = null;
		private Delegate updateTextDelegate = null;
		
		public void Encrypt( object inputObject )
		{
			object[] inputObjects = ( object[] )inputObject;
			containerControl = ( Form ) inputObjects[ 0 ];
			finishedProcessDelegate = ( Delegate ) inputObjects[ 1 ];
			updateTextDelegate = ( Delegate )inputObjects[ 2 ];
			string encryptedString = EncryptString( ( string )inputObjects[ 3 ], ( int )inputObjects[ 4 ], ( string )inputObjects[ 5 ] );
			containerControl.Invoke( updateTextDelegate, new object[] { encryptedString } );
			containerControl.Invoke( finishedProcessDelegate );			
		}

		public void Decrypt( object inputObject )
		{
			object[] inputObjects = ( object[] )inputObject;
			containerControl = ( Form )inputObjects[ 0 ];
			finishedProcessDelegate = ( Delegate )inputObjects[ 1 ];
			updateTextDelegate = ( Delegate )inputObjects[ 2 ];
			string decryptedString = DecryptString( ( string )inputObjects[ 3 ], ( int )inputObjects[ 4 ], ( string )inputObjects[ 5 ] );
			containerControl.Invoke( updateTextDelegate, new object[] { decryptedString } );
			containerControl.Invoke( finishedProcessDelegate );
		}

		public string EncryptString( string inputString, int dwKeySize, string xmlString )
		{
			// TODO: Add Proper Exception Handlers
			RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider( dwKeySize );
			rsaCryptoServiceProvider.FromXmlString( xmlString );
			int keySize = dwKeySize / 8;
			byte[] bytes = Encoding.UTF32.GetBytes( inputString );
			// The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
			// int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
			int maxLength = keySize - 42;
			int dataLength = bytes.Length;
			int iterations = dataLength / maxLength;
			StringBuilder stringBuilder = new StringBuilder();
			for( int i = 0; i <= iterations; i++ )
			{
				byte[] tempBytes = new byte[ ( dataLength - maxLength * i > maxLength ) ? maxLength : dataLength - maxLength * i ];
				Buffer.BlockCopy( bytes, maxLength * i, tempBytes, 0, tempBytes.Length );
				byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt( tempBytes, true );
				// Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
				// If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
				// Comment out the next line and the corresponding one in the DecryptString function.
				Array.Reverse( encryptedBytes );
				// Why convert to base 64?
				// Because it is the largest power-of-two base printable using only ASCII characters
				stringBuilder.Append( Convert.ToBase64String( encryptedBytes ) );				
			}			
			return stringBuilder.ToString();
		}

		public string DecryptString( string inputString, int dwKeySize, string xmlString )
		{
			// TODO: Add Proper Exception Handlers
			RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider( dwKeySize );
			rsaCryptoServiceProvider.FromXmlString( xmlString );
			int base64BlockSize = ( ( dwKeySize / 8 ) % 3 != 0 ) ? ( ( ( dwKeySize / 8 ) / 3 ) * 4 ) + 4 : ( ( dwKeySize / 8 ) / 3 ) * 4;
			int iterations = inputString.Length / base64BlockSize;
			ArrayList arrayList = new ArrayList();
			for( int i = 0; i < iterations; i++ )
			{
				byte[] encryptedBytes = Convert.FromBase64String( inputString.Substring( base64BlockSize * i, base64BlockSize ) );
				// Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
				// If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
				// Comment out the next line and the corresponding one in the EncryptString function.
				Array.Reverse( encryptedBytes );
				arrayList.AddRange( rsaCryptoServiceProvider.Decrypt( encryptedBytes, true ) );				
			}			
			return Encoding.UTF32.GetString( arrayList.ToArray( Type.GetType( "System.Byte" ) ) as byte[] );
		}
	}
}