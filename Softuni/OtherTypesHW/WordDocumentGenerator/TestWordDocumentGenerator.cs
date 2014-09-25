namespace WordDocumentGenerator
{
    using System;
    using System.Drawing;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Novacode;

    class TestWordDocumentGenerator
    {
        static void Main(string[] args)
        {
            string filename = @"../../docxFile.docx";

            using (var doc = DocX.Create(filename))
            {
                // text parts
                string titleText = "SoftUni OOP Game Contest";
                                
                // formattings
                var titleFrmt = new Formatting();
                titleFrmt.Bold = true;
                titleFrmt.Size = 25D;

                // Creating parts to be inserted
                Picture mainPic = doc.AddImage(@"../../images/OOPContestImage.png").CreatePicture();

                // Insert single parts
                var title = doc.InsertParagraph(titleText, false, titleFrmt);
                title.Alignment = Alignment.center;

                Paragraph p = doc.InsertParagraph("", false);
                p.InsertPicture(mainPic);

                doc.InsertParagraph("", false);

                Paragraph mainText = doc.InsertParagraph("", false);
                mainText.Append("SoftUni is organizing a contest for the best ").
                    Append("role playing game ").Bold().
                    Append("from the OOP teamwork ").
                    AppendLine("projects. The winnig teams will receive a ").
                    Append("grand prize").Bold().UnderlineColor(Color.Black).
                    Append("!").
                    AppendLine("The game shoud be: ");

                var gameCriteriaList = doc.AddList("First Bulleted Item.", 0, ListItemType.Bulleted);
               
                doc.InsertList(gameCriteriaList);

                doc.Save();
            }
        }
    }
}
