using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDMAPSM.打印
{
    class CCWordApp
    {
        private Microsoft.Office.Interop.Word.ApplicationClass oWordApplic; // a reference to Word application 引用Word应用程序
        private Microsoft.Office.Interop.Word.Document oDoc;                    // a reference to the document 引用文档


        public CCWordApp()
        {
            // activate the interface with the COM object of Microsoft Word
            //激活与Microsoft Word的COM对象的接口
            oWordApplic = new Microsoft.Office.Interop.Word.ApplicationClass();
        }

        /// <summary>
        /// 插入图片
        /// </summary>
        /// <param name="picPath"></param>
        public void InsertPicture(string picPath)
        {
            object missing = System.Reflection.Missing.Value;
            oWordApplic.Selection.InlineShapes.AddPicture(picPath, ref missing, ref missing, ref missing);
        }

        // Open a file (the file must exists) and activate it  打开一个文件（该文件必须存在），并激活它
        public void Open(string strFileName)
        {
            object fileName = strFileName;
            object readOnly = false;
            object isVisible = true;
            object missing = System.Reflection.Missing.Value;

            oDoc = oWordApplic.Documents.Open(ref fileName, ref missing, ref readOnly,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing);

            oDoc.Activate();
        }


        // Open a new document打开一个新文档
        public void Open()
        {
            object missing = System.Reflection.Missing.Value;
            oDoc = oWordApplic.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            oDoc.Activate();
        }




        public void Quit()
        {
            object missing = System.Reflection.Missing.Value;
            oWordApplic.Application.Quit(ref missing, ref missing, ref missing);
        }

        public void Save()
        {
            oDoc.Save();
        }

        public void SaveAs(string strFileName)
        {
            object missing = System.Reflection.Missing.Value;
            object fileName = strFileName;

            oDoc.SaveAs(ref fileName, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }

        // Save the document in HTML format 以HTML格式保存文档
        public void SaveAsHtml(string strFileName)
        {
            object missing = System.Reflection.Missing.Value;
            object fileName = strFileName;
            object Format = (int)Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatHTML;
            oDoc.SaveAs(ref fileName, ref Format, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
        }



        public void InsertText(string strText)
        {
            oWordApplic.Selection.TypeText(strText);
        }

        public void InsertLineBreak()
        {
            oWordApplic.Selection.TypeParagraph();
        }
        public void InsertLineBreak(int nline)
        {
            for (int i = 0; i < nline; i++)
                oWordApplic.Selection.TypeParagraph();
        }


        // Change the paragraph alignement 更改段落对齐键相
        public void SetAlignment(string strType)
        {
            switch (strType)
            {
                case "Center":
                    oWordApplic.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    break;
                case "Left":
                    oWordApplic.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    break;
                case "Right":
                    oWordApplic.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                    break;
                case "Justify":
                    oWordApplic.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    break;
            }

        }


        // if you use thif function to change the font you should call it again with 如果您使用此功能来改变字体，你应该再次调用它 
        // no parameter in order to set the font without a particular format 为了不带参数设置字体没有特定的格式
        public void SetFont(string strType)
        {
            switch (strType)
            {
                case "Bold":
                    oWordApplic.Selection.Font.Bold = 1;
                    break;
                case "Italic":
                    oWordApplic.Selection.Font.Italic = 1;
                    break;
                case "Underlined":
                    oWordApplic.Selection.Font.Subscript = 0;
                    break;
            }

        }

        // disable all the style  禁用所有的风格
        public void SetFont()
        {
            oWordApplic.Selection.Font.Bold = 0;
            oWordApplic.Selection.Font.Italic = 0;
            oWordApplic.Selection.Font.Subscript = 0;

        }

        public void SetFontName(string strType)
        {
            oWordApplic.Selection.Font.Name = strType;

        }

        public void SetFontSize(int nSize)
        {
            oWordApplic.Selection.Font.Size = nSize;

        }

        public void InsertPagebreak()
        {
            // VB : Selection.InsertBreak Type:=wdPageBreak
            object pBreak = (int)Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak;
            oWordApplic.Selection.InsertBreak(ref pBreak);
        }

        // Go to a predefined bookmark, if the bookmark doesn't exists the application will raise an error 
        //去到一个预先定义的书签，如果书签不存在应用程序将引发错误
        public void GotoBookMark(string strBookMarkName)
        {
            // VB :  Selection.GoTo What:=wdGoToBookmark, Name:="nome"
            object missing = System.Reflection.Missing.Value;

            object Bookmark = (int)Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark;
            object NameBookMark = strBookMarkName;
            oWordApplic.Selection.GoTo(ref Bookmark, ref missing, ref missing, ref NameBookMark);
        }

        public void GoToTheEnd()
        {
            // VB :  Selection.EndKey Unit:=wdStory
            object missing = System.Reflection.Missing.Value;
            object unit;
            unit = Microsoft.Office.Interop.Word.WdUnits.wdStory;
            oWordApplic.Selection.EndKey(ref unit, ref missing);

        }
        public void GoToTheBeginning()
        {
            // VB : Selection.HomeKey Unit:=wdStory
            object missing = System.Reflection.Missing.Value;
            object unit;
            unit = Microsoft.Office.Interop.Word.WdUnits.wdStory;
            oWordApplic.Selection.HomeKey(ref unit, ref missing);

        }

        public void GoToTheTable(int ntable)
        {
            //	Selection.GoTo What:=wdGoToTable, Which:=wdGoToFirst, Count:=1, Name:=""
            //    Selection.Find.ClearFormatting
            //    With Selection.Find
            //        .Text = ""
            //        .Replacement.Text = ""
            //        .Forward = True
            //        .Wrap = wdFindContinue
            //        .Format = False
            //        .MatchCase = False
            //        .MatchWholeWord = False
            //        .MatchWildcards = False
            //        .MatchSoundsLike = False
            //        .MatchAllWordForms = False
            //    End With

            object missing = System.Reflection.Missing.Value;
            object what;
            what = Microsoft.Office.Interop.Word.WdUnits.wdTable;
            object which;
            which = Microsoft.Office.Interop.Word.WdGoToDirection.wdGoToFirst;
            object count;
            count = 1;
            oWordApplic.Selection.GoTo(ref what, ref which, ref count, ref missing);
            oWordApplic.Selection.Find.ClearFormatting();

            oWordApplic.Selection.Text = "";


        }

        public void GoToRightCell()
        {
            // Selection.MoveRight Unit:=wdCell

            object missing = System.Reflection.Missing.Value;
            object direction;
            direction = Microsoft.Office.Interop.Word.WdUnits.wdCell;
            oWordApplic.Selection.MoveRight(ref direction, ref missing, ref missing);
        }

        public void GoToLeftCell()
        {
            // Selection.MoveRight Unit:=wdCell

            object missing = System.Reflection.Missing.Value;
            object direction;
            direction = Microsoft.Office.Interop.Word.WdUnits.wdCell;
            oWordApplic.Selection.MoveLeft(ref direction, ref missing, ref missing);
        }

        public void GoToDownCell()
        {
            // Selection.MoveRight Unit:=wdCell

            object missing = System.Reflection.Missing.Value;
            object direction;
            direction = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            oWordApplic.Selection.MoveDown(ref direction, ref missing, ref missing);
        }

        public void GoToUpCell()
        {
            // Selection.MoveRight Unit:=wdCell

            object missing = System.Reflection.Missing.Value;
            object direction;
            direction = Microsoft.Office.Interop.Word.WdUnits.wdLine;
            oWordApplic.Selection.MoveUp(ref direction, ref missing, ref missing);
        }


        // this function doesn't work 这个功能不起作用
        public void InsertPageNumber(string strType, bool bHeader)
        {
            object missing = System.Reflection.Missing.Value;
            object alignment;
            object bFirstPage = false;
            object bF = true;
            //if (bHeader == true)
            //WordApplic.Selection.HeaderFooter.PageNumbers.ShowFirstPageNumber = bF;
            switch (strType)
            {
                case "Center":
                    alignment = Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
                    //WordApplic.Selection.HeaderFooter.PageNumbers.Add(ref alignment,ref bFirstPage);
                    //Word.Selection objSelection = WordApplic.pSelection;

                    //oWordApplic.Selection.HeaderFooter.PageNumbers.Item(1).Alignment = Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberCenter;
                    break;
                case "Right":
                    alignment = Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberRight;
                    //oWordApplic.Selection.HeaderFooter.PageNumbers.Item(1).Alignment = Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberRight;
                    break;
                case "Left":
                    alignment = Microsoft.Office.Interop.Word.WdPageNumberAlignment.wdAlignPageNumberLeft;
                    oWordApplic.Selection.HeaderFooter.PageNumbers.Add(ref alignment, ref bFirstPage);
                    break;
            }
        }
    }
}


        

