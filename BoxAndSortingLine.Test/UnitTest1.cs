using ParcelSorting;
using System;
using System.Collections.Generic;
using Xunit;

namespace BoxAndSortingLine.Test
{
    public class UnitTest1
    {
        [Fact]
        public void When_ParcelHasNewDimensionsAndSameWithSortingLine_Then_ParcelCanNotFitSortingLine()
        {
            var boxSizes = new List<BoxSize>()
            {
                   new BoxSize
            {
                Length = 200,
                Width = 87,
                SortingLineParams = new List<SortingLineParam>
                {
                    new SortingLineParam
                    {
                        LineWidth = 75
                    }
                }
            }
            };
            }
    }
}
   
