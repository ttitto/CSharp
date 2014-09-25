namespace WordDocumentGenerator
{
    using System.Drawing;
    using Novacode;

    class TestWordDocumentGenerator
    {
        static void Main()
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

                // Main paragraph
                Paragraph mainText = doc.InsertParagraph("", false);
                mainText.Append("SoftUni is organizing a contest for the best ").
                    Append("role playing game ").Bold().
                    Append("from the OOP teamwork ").
                    Append("projects. The winnig teams will receive a ").
                    Append("grand prize").Bold().UnderlineColor(Color.Black).
                    Append("!").
                    AppendLine("The game shoud be: ");
                mainText.IndentationAfter = 2.0f;

                // Bulleted List
                var gameCriteriaList = doc.AddList("Properly structured and follow all good OOP practices", 0, ListItemType.Bulleted);
                doc.AddListItem(gameCriteriaList, "Awesome");
                doc.AddListItem(gameCriteriaList, "...Very Awesome");
                doc.InsertList(gameCriteriaList);

                doc.InsertParagraph("");

                // Table
                Table teamsResultTable = doc.AddTable(4, 3);
                teamsResultTable.Alignment = Alignment.center;
                teamsResultTable.AutoFit = AutoFit.Window;

                teamsResultTable.Rows[0].Cells[0].FillColor = Color.FromArgb(84, 141, 212);
                teamsResultTable.Rows[0].Cells[0].Paragraphs[0].Append("Team").Color(Color.White).Bold().Alignment = Alignment.center;

                teamsResultTable.Rows[0].Cells[1].FillColor = Color.FromArgb(84, 141, 212);
                teamsResultTable.Rows[0].Cells[1].Paragraphs[0].Append("Game").Color(Color.White).Bold().Alignment = Alignment.center;

                teamsResultTable.Rows[0].Cells[2].FillColor = Color.FromArgb(84, 141, 212);
                teamsResultTable.Rows[0].Cells[2].Paragraphs[0].Append("Points").Color(Color.White).Bold().Alignment = Alignment.center;

                teamsResultTable.Rows[1].Cells[0].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[2].Cells[0].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[3].Cells[0].Paragraphs[0].Append("-").Alignment = Alignment.center;

                teamsResultTable.Rows[1].Cells[1].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[2].Cells[1].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[3].Cells[1].Paragraphs[0].Append("-").Alignment = Alignment.center;

                teamsResultTable.Rows[1].Cells[2].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[2].Cells[2].Paragraphs[0].Append("-").Alignment = Alignment.center;
                teamsResultTable.Rows[3].Cells[2].Paragraphs[0].Append("-").Alignment = Alignment.center;

                doc.InsertTable(teamsResultTable);

                doc.InsertParagraph("");

                doc.InsertParagraph("The top 3 teams will receive a ").
                    Append("Spectacular ").Bold().CapsStyle(CapsStyle.caps).
                    Append("prize:").
                    Alignment = Alignment.center;

                doc.InsertParagraph("A handshake from Nakov").
                    Bold().
                    Color(Color.FromArgb(23, 54, 93)).
                    UnderlineColor(Color.FromArgb(23, 54, 93)).
                    CapsStyle(CapsStyle.caps).
                    FontSize(24D).
                    Alignment = Alignment.center;

                doc.Save();
            }
        }
    }
}
