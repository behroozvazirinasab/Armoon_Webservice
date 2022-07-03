using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmoonWebServiceSystem.Models
{
    public class Gooddatamodel
    {
        public class InsertGoodmodel
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public long? Type { get; set; }
            public long? UnitIdRef { get; set; }
            public long? MainGroupCodeRef { get; set; }
            public long? SecondGroupCodeRef { get; set; }
            public byte? Pic { get; set; }              //
            public Boolean? IsAdded { get; set; }
            public byte[] ImageData { get; set; }      //
            public Boolean? IsBuyAdded { get; set; }
            public string Serial { get; set; }
            public decimal? FiPrice1 { get; set; }
            public decimal? OffPercent1 { get; set; }
            public decimal? FiPrice2 { get; set; }
            public decimal? OffPercent2 { get; set; }
            public decimal? FiPrice3 { get; set; }
            public decimal? OffPercent3 { get; set; }
            public string SaleName { get; set; }
            public long? UnitPackingCodeRef { get; set; }
            public decimal? TaxPercent { get; set; }
            public decimal? lengthValue { get; set; }
            public decimal? WidthValue { get; set; }
            public decimal? HeightValue { get; set; }
            public long? GoodCategoryIdRef { get; set; }
            public Boolean? IsActive { get; set; }
            public decimal? DiameterValue { get; set; }
            public Boolean? SerialsControl { get; set; }
            public long? PatternIdRef { get; set; }
            public string NationalCode { get; set; }
            public decimal? WeightPack { get; set; }
            public decimal? WeightGoods { get; set; }
            public long? CriterionWeight { get; set; }
            public decimal? DimensionsLengthPack { get; set; }
            public decimal? DimensionsWidthPack { get; set; }
            public decimal? DimensionsHeightPack { get; set; }
            public decimal? DimensionsLengthGoods { get; set; }
            public decimal? DimensionsWidthGoods { get; set; }
            public decimal? DimensionsHeightGoods { get; set; }
            public long? CriterionDimensions { get; set; }

        }

        public class SearchGoodmodel
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public long? Type { get; set; }
            public string UnitsName { get; set; }
            public string MainGroupName { get; set; }
            public string SecondGroupName { get; set; }
            public string Serial { get; set; }              
            public decimal? FiPrice1 { get; set; }
            public decimal? OffPercent1 { get; set; }      
            public decimal? FiPrice2 { get; set; }
            public decimal? OffPercent2 { get; set; }
            public decimal? FiPrice3 { get; set; }
            public decimal? OffPercent3 { get; set; }
            public string SaleName { get; set; }
            public string UnitPackingName { get; set; }
            public decimal? TaxPercent { get; set; }
            public decimal? lengthValue { get; set; }
            public decimal? WidthValue { get; set; }
            public decimal? HeightValue { get; set; }
            public string GoodCategoryName { get; set; }
            public string IsActive { get; set; }
            public decimal? DiameterValue { get; set; }
            public string GoodPatternName { get; set; }
            public string NationalCode { get; set; }
            public decimal? WeightPack { get; set; }
            public decimal? WeightGoods { get; set; }
            
        }

        public class ResponseModel
        {
            //public T Result { get; set; }

            public long? ErrorCode { get; set; }

            public string ErrorMessage { get; set; }
        }


        public class ResponseModelSearch
        {
            //public T Result { get; set; }

            public string Code { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string UnitName { get; set; }
            public string MainGroupName { get; set; }
            public string SeconfGroupName { get; set; }
            public byte? Pic { get; set; }              
            public string IsAdded { get; set; }
            public byte[] ImageData { get; set; }      
            public string IsBuyAdded { get; set; }
            public string Serial { get; set; }
            public string FiPrice1 { get; set; }
            public string OffPercent1 { get; set; }
            public string FiPrice2 { get; set; }
            public string OffPercent2 { get; set; }
            public string FiPrice3 { get; set; }
            public string OffPercent3 { get; set; }
            public string SaleName { get; set; }
            public string TaxPercent { get; set; }
            public string lengthValue { get; set; }
            public string WidthValue { get; set; }
            public string HeightValue { get; set; }
            public string IsActive { get; set; }
            public string DiameterValue { get; set; }
            public string NationalCode { get; set; }
            public string WeightPack { get; set; }
            public string WeightGoods { get; set; }
            public long? CriterionWeight { get; set; }
            public string DimensionsLengthPack { get; set; }
            public string DimensionsWidthPack { get; set; }
            public string DimensionsHeightPack { get; set; }
            public string DimensionsLengthGoods { get; set; }
            public string DimensionsWidthGoods { get; set; }
            public string DimensionsHeightGoods { get; set; }
            public long? CriterionDimensions { get; set; }
        }
    }
}