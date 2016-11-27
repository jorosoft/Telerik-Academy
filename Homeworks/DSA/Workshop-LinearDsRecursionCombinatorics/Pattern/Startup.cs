using System;
using System.Text;

namespace Pattern
{
    internal class Startup
    {
        internal static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string figure = GenerateFigure(n);
            Console.WriteLine(figure);

            // comment before submitting
            var pathForSvgFile = "../../SvgFiles/output.svg";
            Svg.WriteToFile(pathForSvgFile, figure);
        }

        public static string GenerateFigure(int n)
        {
            string result = string.Empty;
            string baseFigure = "urd";

            if (n > 1)
            {               
                var figure = baseFigure;
                for (int i = 1; i < n; i++)
                {
                    result = TransformFigure(figure, n);
                    figure = result;
                }

                return result;
            }
            else
            {
                return baseFigure;
            }
        }

        private static string TransformFigure(string figure, int n)
        {
            var result = new StringBuilder();
            
            result.Append(Rotate90(figure));
            result.Append('u');
            result.Append(figure);
            result.Append('r');
            result.Append(figure);
            result.Append('d');
            result.Append(Rotate270(figure));

            return result.ToString();
        }

        private static StringBuilder Rotate90(string figure)
        {
            var result = new StringBuilder();

            for (int i = 0; i < figure.Length; i++)
            {
                switch (figure[i])
                {
                    case 'u':
                        result.Append('r');
                        break;
                    case 'r':
                        result.Append('u');
                        break;
                    case 'd':
                        result.Append('l');
                        break;
                    case 'l':
                        result.Append('d');
                        break;
                    default:
                        break;
                }
            }

            return result;
        }       

        private static StringBuilder Rotate270(string figure)
        {
            var result = new StringBuilder();

            for (int i = 0; i < figure.Length; i++)
            {
                switch (figure[i])
                {
                    case 'u':
                        result.Append('l');
                        break;
                    case 'r':
                        result.Append('d');
                        break;
                    case 'd':
                        result.Append('r');
                        break;
                    case 'l':
                        result.Append('u');
                        break;
                    default:
                        break;
                }
            }

            return result;
        }        
    }
}
