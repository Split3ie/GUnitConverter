using HammerUnitsConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerUnitsConverter.Logic
{
    public class UnitConverter
    {
        //1 unit = 190.5mm
        private const float OneUnitToMM = 190.5f;
        //1 cm = 0.39370079 inches
        private const float OneCmToInches = 0.39370079f;
        //1 inch = 0.0833333 foot
        private const float OneInchToFeet = 0.0833333f;

        private float Round(float value)
        {
            return (float)Math.Round(value, 2);
        }

        /// <summary>
        /// Doing convert from one of type to others
        /// </summary>
        /// <param name="convert"></param>
        /// <returns>Model with converted values</returns>
        public ConvertModel DoConvert(ConvertModel convert)
        {
            if (convert == null)
                return convert;
            switch (convert.Source)
            {
                case SourceScale.Unit:
                    convert.Cm = Round(ConvertUnitToCm(convert.Units));
                    convert.M = Round(convert.Cm / 100);
                    convert.Inches = Round(ConvertUnitToInch(convert.Units));
                    convert.Feet = Round(convert.Inches * OneInchToFeet);
                    break;
                case SourceScale.Cm:
                    convert.Units = Round(ConvertCmToUnit(convert.Cm));
                    convert.M = Round(convert.Cm / 100);
                    convert.Inches = Round(ConvertUnitToInch(convert.Units));
                    convert.Feet = Round(convert.Inches * OneInchToFeet);
                    break;
                case SourceScale.Inch:
                    convert.Units = Round(ConvertInchToUnit(convert.Inches));
                    convert.Cm = Round(ConvertUnitToCm(convert.Units));
                    convert.M = Round(convert.Cm / 100);
                    convert.Feet = Round(convert.Inches * OneInchToFeet);
                    break;
                case SourceScale.M:
                    convert.Cm = Round(convert.M * 100);
                    convert.Units = Round(ConvertCmToUnit(convert.Cm));
                    convert.Inches = Round(ConvertUnitToInch(convert.Units));
                    convert.Feet = Round(convert.Inches * OneInchToFeet);
                    break;
                case SourceScale.Foot:
                    convert.Inches = Round(convert.Feet / OneInchToFeet);
                    convert.Units = Round(ConvertInchToUnit(convert.Inches));
                    convert.Cm = Round(ConvertUnitToCm(convert.Units));
                    convert.M = Round(convert.Cm / 100);
                    break;
            }
            return convert;
        }
        /// <summary>
        /// Gererate file with converted values saved before in hostory
        /// </summary>
        /// <param name="history"></param>
        /// <returns>String with generated table of converted values</returns>
        public string GenerateFile(List<HistoryViewModel> history)
        {
            try
            {
                var line = "|--------------+--------------+--------------+--------------+--------------|";
                var file = new StringBuilder();

                file.AppendLine(string.Format("| {0,-12} | {1,-12} | {2,-12} | {3,-12} | {4,-12} |", nameof(HistoryViewModel.Units), nameof(HistoryViewModel.Cm), nameof(HistoryViewModel.M), nameof(HistoryViewModel.Inches), nameof(HistoryViewModel.Feet)));// $"| {nameof(HistoryViewModel.Units)} | {nameof(HistoryViewModel.Cm)} | {nameof(HistoryViewModel.M)} | {nameof(HistoryViewModel.Inches)} | {nameof(HistoryViewModel.Foot)} |");
                file.AppendLine(line);

                foreach (var item in history)
                {
                    file.AppendLine(string.Format("| {0,-12} | {1,-12} | {2,-12} | {3,-12} | {4,-12} |", item.Units, item.Cm, item.M, item.Inches, item.Feet));
                    file.AppendLine(line);
                }

                var result = file.ToString();
                var s = result.LastIndexOf(line);
                //+2 because \n
                result = result.Remove(s - 2, line.Length + 2);
                result += "|--------------------------------------------------------------------------|";
                return result;
            }
            catch
            {
                throw new Exception("Couldn't generate history  file.");
            }
        }
        #region Convert methods
        /// <summary>
        /// Convert Units to Cm scale
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        private float ConvertUnitToCm(float units)
        {
            return units * (OneUnitToMM / 100);
        }
        /// <summary>
        /// Convert Cm to Unit scale
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        private float ConvertCmToUnit(float cm)
        {
            return cm / OneUnitToMM * 100;
        }

        /// <summary>
        /// Convert Unit to Inches
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        private float ConvertUnitToInch(float units)
        {
            return units * 0.75f;
        }
        /// <summary>
        /// Convert Inches to Unit
        /// </summary>
        /// <param name="inches"></param>
        /// <returns></returns>
        private float ConvertInchToUnit(float inches)
        {
            return inches / 0.75f;
        }

        /// <summary>
        /// Convert Cm to inches scale
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        private float ConvertCmToInch(float cm)
        {
            return cm / OneCmToInches;
        }
        /// <summary>
        /// Covert Inches to Cm
        /// </summary>
        /// <param name="inches"></param>
        /// <returns></returns>
        private float ConvertInchesToCm(float inches)
        {
            return inches * OneCmToInches;
        }
        #endregion
    }
}
