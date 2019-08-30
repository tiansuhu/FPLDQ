using System;
using System.Collections.Generic;
using System.Text;
using Aspose.Cells;
using Aspose.Slides;
using System.IO;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using System.Text.RegularExpressions;
using Aspose.Cells.Rendering;
using Aspose.Words;

namespace FPLDQ.Common
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/29 10:57:11
    //  文件名：AsposeHelper
    //  版本：V1.0.1  
    //  说明： AsposeHelper 对office 的操作等 及相互转换
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    class AsposeHelper
    {


        public AsposeHelper()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        ///将office文件转化成对应的pdf文件
        /// </summary>
        /// <param name="soursefilepath">源文件地址</param>
        /// <param name="outpdfpath">目标文件地址</param>
        /// <param name="worktype">文件类型</param>
        /// <returns></returns>
        public static string GetPdfForApost(string soursefilepath, string outpdfpath, wordType worktype)
        {
            string resoutpdfpath = null;
            if (worktype == wordType.Word)
            {
                if (GetPdfFromWord(soursefilepath, outpdfpath))
                {
                    resoutpdfpath = outpdfpath;
                }
                else
                {
                    resoutpdfpath = null;
                }
            }

            if (worktype == wordType.ExeCel)
            {
                if (GetPdfFromExcel(soursefilepath, outpdfpath))
                {
                    resoutpdfpath = outpdfpath;
                }
                else
                {
                    resoutpdfpath = null;
                }
            }

            if (worktype == wordType.Ppt)
            {
                if (GetPdfFromPPt(soursefilepath, outpdfpath))
                {
                    resoutpdfpath = outpdfpath;
                }
                else
                {
                    resoutpdfpath = null;
                }
            }
            return resoutpdfpath;
        }
        
        #region 将office 转化为对应的pdf文件
        /// <summary>
        ///将word文档转换成pdf
        /// </summary>
        /// <param name="soursefilepath">将源文件地址</param>
        /// <param name="outpdfpath">目标文件地址</param>
        /// <returns></returns>
        public static bool GetPdfFromWord(string soursefilepath, string outpdfpath)
        {
            //读取word文档
            try
            {
                using (System.IO.Stream stream = new System.IO.FileStream(soursefilepath, FileMode.Open, FileAccess.Read))
                {
                    Aspose.Words.Document doc = new Aspose.Words.Document(soursefilepath);
                    doc.Save(outpdfpath, Aspose.Words.SaveFormat.Pdf);
                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 将excel 转化成对应的pdf文件
        /// </summary>
        /// <param name="soursefilepath">源文件地址</param>
        /// <param name="outpdfpath">目表文件地址</param>
        /// <returns></returns>
        public static bool GetPdfFromExcel(string soursefilepath, string outpdfpath)
        {
            try
            {
                using (System.IO.Stream stream = new System.IO.FileStream(soursefilepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {

                    Aspose.Cells.Workbook workbook = new Workbook(stream);
                    Aspose.Words.Saving.PdfSaveOptions pdfSaveOptions = new Aspose.Words.Saving.PdfSaveOptions();
                    pdfSaveOptions.Compliance = Aspose.Words.Saving.PdfCompliance.PdfA1b;
                    workbook.Save(outpdfpath, Aspose.Cells.SaveFormat.Pdf);
                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// ppt文档转换成pdf
        /// </summary>
        /// <param name="soursefilepath">源文件地址</param>
        /// <param name="outpdfpath">目表文件地址</param>
        /// <returns></returns>
        public static bool GetPdfFromPPt(string soursefilepath, string outpdfpath)
        {
            try
            {
                using (System.IO.Stream stream = new System.IO.FileStream(soursefilepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    Presentation ppt = new Presentation(stream);
                    ppt.Save(outpdfpath, Aspose.Slides.Export.SaveFormat.Pdf);//
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region 将各个文件转化成对应的格式在移动端展示
        /// <summary>
        /// Excel 转jpeg
        /// </summary>
        /// <param name="attachmentcontent"></param>
        /// <param name="fileName"></param>
        /// <param name="newfilename"></param>
        /// <returns></returns>
        public static void ExcelToJpeg(byte[] attachmentcontent, string fileName, string newfilename)
        {
           
        }

        /// <summary>
        /// Excel 转Html 文件
        /// </summary>
        /// <param name="attachmentcontent"></param>
        /// <param name="fileName"></param>
        /// <param name="newfilename"></param>
        /// <returns></returns>
        public static void ExcelToHtml(byte[] attachmentcontent, string fileName, string newfilename)
        {
           

        }

        /// <summary>
        /// Word 转Html 文件
        /// </summary>
        /// <param name="attachmentcontent"></param>
        /// <param name="fileName"></param>
        /// <param name="newfilename"></param>
        /// <returns></returns>
        public static void WrodToHtml(byte[] attachmentcontent, string fileName, string newfilename)
        {
            
           
        }

        /// <summary>
        /// 将ppt的二进制流转化为对应图片的baseb4string
        /// </summary>
        /// <param name="attachmentcontent"></param>
        /// <returns></returns>
        public static void PptToJpeg(byte[] attachmentcontent)
        {

           

        }

        /// <summary>
        /// 获取excel Sheet页的html
        /// </summary>
        /// <param name="b"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static void getExcelSheet(Workbook book, int sheetIndex, string fileName)
        {
           

        }

        /// <summary>
        /// excel sheet 转jpeg
        /// </summary>
        /// <param name="book"></param>
        /// <param name="sheetIndex"></param>
        /// <param name="fileName"></param>
        public static void getExcelSheetToJPge(Workbook book, int sheetIndex, string fileName)
        {
            


        }
        #endregion
        public enum wordType
        {
            None,
            Word,
            ExeCel,
            Ppt,
            Txt,
            Pdf
        }
    }


}

