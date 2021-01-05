// Goal:  merge 2 seperate PDF files into 1 new PDF file
// The method MergePDF in class Program will execute your new PDF


namespace MergePDF
{
    class Program
    {

        private static void MergePDF()
        {
            // Create 2 variables for your files and pass both as parameter




            // Add a new string for the output path destintion. You can call it newFile.pdf
            

            // You might need these for the next steps
			Document sourceDocument = null;
            sourceDocument = new Document();

            PdfCopy pdfCopyProvider = null;
            pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

            PdfReader reader = null;
            PdfImportedPage importedPage;

            // Open the document 
            


            // Create a for loop for your files
            // Create a variable to count all the pages of your PDF and put it into a new PDF reader
         
		 
		 
                

                

                // Create a for loop to add the pages in your new file
                // Afterwards, use the variables as mentionned above

                
				
				
				
				

                reader.Close();
            }

            // Save (close) the document 
            
			
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
		
		
		static void Main(string[] args)
        {
            // Call the MergePDF function and give the path where you store the 2 files
            
        }
    }
}

