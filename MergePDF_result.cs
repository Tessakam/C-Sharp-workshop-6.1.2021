// Goal:  merge 2 seperate PDF files into 1 new PDF file
// The method MergePDF in class Program will execute your new PDF

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;


namespace MergePDF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the MergePDF function and give the path where you store the 2 files
			// You can store this method te
            MergePDF(@"D:\PDF1.pdf", @"D:\PDF2.pdf");
        }

        // Create 2 variables for your files and pass both as parameter
        private static void MergePDF(string File1, string File2)
        {
            // Add a new string for the output path destintion. You can call it newFile.pdf
            string[] fileArray = new string[3];
            fileArray[0] = File1;
            fileArray[1] = File2;

            // You might need these for the next steps
            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage;
            string outputPdfPath = @"D:/newFile.pdf";

            sourceDocument = new Document();
            pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

            // Open the document 
            sourceDocument.Open();


            // Create a for loop for your files
            // Create a variable to count all the pages of your PDF and put it into a new PDF reader  
            for (int f = 0; f < fileArray.Length - 1; f++)
            {
                int pages = TotalPageCount(fileArray[f]);

                reader = new PdfReader(fileArray[f]);
                // Create a for loop to add the pages in your new file
                // Afterwards, use the variables as mentionned above  
                for (int i = 1; i <= pages; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                }

                reader.Close();
            }
            // Save (close) the document 
            sourceDocument.Close();
        }

        private static int TotalPageCount(string file)
        {
            // The StreamReader creates an instance to read from a file till the end of the file is reached
            using (StreamReader sr = new StreamReader(System.IO.File.OpenRead(file)))
            {
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(sr.ReadToEnd());

                return matches.Count;
            }
        }
    }
}

