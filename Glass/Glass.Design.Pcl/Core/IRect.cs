using Glass.Design.Pcl.DesignSurface;

namespace Glass.Design.Pcl.Core
{
    public interface IRect : ICoordinate
    {
        double Left { get; }
        double Top { get; }
        double Width { get; set; }
        double Height { get; set; }
        ISize Size { get; set; }
        IPoint Location { get; set; }
        double X { get; set; }
        double Y { get; set; }
        double Right { get; }
        double Bottom { get; }
    }
}