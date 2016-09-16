namespace Measurement
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; protected set; }

        public double Height { get; protected set; }

        public static Size GetRotatedSize(
            Size size, 
            double angleOfTheRotatedFigure)
        {
            var rotatedWidth = (Math.Abs(Math.Cos(angleOfTheRotatedFigure)) * size.Width) +
                    (Math.Abs(Math.Sin(angleOfTheRotatedFigure)) * size.Height);
            var rotatedHeight = (Math.Abs(Math.Sin(angleOfTheRotatedFigure)) * size.Width) +
                    (Math.Abs(Math.Cos(angleOfTheRotatedFigure)) * size.Height);

            var rotatedSize = new Size(rotatedWidth, rotatedHeight);

            return rotatedSize;
        }
    }
}
