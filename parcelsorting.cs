using System;
using System.Collections.Generic;

namespace ParcelSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
        public static bool ParcelLineFitController(List<BoxSize> boxSizes)
        {
            bool parcelFits = false;

            foreach (BoxSize box in boxSizes)
            {
                Console.WriteLine("New sorting line starts");

                var boxLengthInHalf = box.Length / 2; 

                var halfBoxDiagonalNotSqrt = (boxLengthInHalf * boxLengthInHalf) + (box.Width * box.Width);
                var halfParcelDiagonal = Math.Sqrt(halfBoxDiagonalNotSqrt);

                


                foreach (SortingLineParam sortingLine in box.SortingLineParams)
                {
                    var lineWidth = 0;
                    var sortingLineNotSqrt = (sortingLine.Width * sortingLine.Width) + (lineWidth * lineWidth);
                    var halfParcelDiagonal = Math.Sqrt(sortingLineNotSqrt);

                    if (sortingLine.Width >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and its fits", sortingLine.Width);
                    }

                    else if (sortingLine.Width <= halfParcelDiagonal && lineWidth >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and its fits", sortingLine.Width);
                    }

                    else if (box.Width <= halfParcelDiagonal && lineWidth >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and its fits", sortingLine.Width);
                    }
                    else if (box.Width >= halfParcelDiagonal)
                    {
                        Console.WriteLine("Sorting line width is {0} and its fits", sortingLine.Width);
                    }
                    else if (sortingLine.Width <= halfParcelDiagonal && sortingLine.Width >= parcelDagonal)
                    {
                        parcelFits = sortingLine.Width <= halfParcelDiagonal && sortingLine.Width >= parcelDagonal;

                        var result = parcelFits ?
                            "Sorting line width is " + sortingLine.Width + " and it fits " :
                            "it doesnt fit to the sorting line and needs to be wider";

                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("it did not fit to the sortingline and needs to be wider");
                    }
                }

                {

                }
            }
            return parcelFits;
        }
    }

    public static readonly List<BoxSize> BoxSizes = new List<BoxSize>
    {
        new BoxSize
        {
            Length = 120,
            Width = 60,
            SortingLineParams = new List<SortingLineParam>
            {
                new SortingLineParam
                {
                    LineWidth = 100
                },
                new SortingLineParam
                {
                    LineWidth= 75
                }
            }
        },
        new BoxSize
        {
            Length = 100,
            Width = 35,
            SortingLineParams = new List<SortingLineParam>
            {
                new SortingLineParam
                {
                    LineWidth = 75
                },
                new SortingLineParam
                {
                    LineWidth= 50
                },
                new SortingLineParam
                {
                    LineWidth = 80
                },
        new SortingLineParam
                {
                    LineWidth= 100
                },
                new SortingLineParam
                {
                    LineWidth= 37
                }
            }
        },
    new BoxSize
        {
            Length = 70,
            Width = 50,
            SortingLineParams = new List<SortingLineParam>
            {
                new SortingLineParam
                {
                    LineWidth = 60
                },
                new SortingLineParam
                {
                    LineWidth= 60
                },
                new SortingLineParam
                {
                    LineWidth = 55
                },
                new SortingLineParam
                {
                    LineWidth= 90
                }
            }
        }
    };