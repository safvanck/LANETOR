using System;
using System.Drawing;

[System.Serializable()]
public class Settings
{
    private Point location;
    private Font font;
    private int height;
    private int width;
    private bool wrapping;

    public Point Location
    {
        get
        { return location; }
        set
        { location = value; }
    }

    public Font Font
    {
        get
        { return font; }
        set
        { font = value; }
    }

    public int Height
    {
        get
        { return height; }
        set
        { height = value; }
    }

    public int Width
    {
        get
        { return width; }
        set
        { width = value; }
    }

    public bool Wrapping
    {
        get
        { return wrapping; }
        set
        { wrapping = value; }
    }
}