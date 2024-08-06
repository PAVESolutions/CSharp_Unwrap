using OpenCvSharp;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Starting the program...");

            // Path to your config file
            string configFilePath = "configWDR.txt";

            // Load the image
            Console.WriteLine("Loading the image...");
            Mat img = Cv2.ImRead("test.png");
            Console.WriteLine($"Image loaded - Width: {img.Width}, Height: {img.Height}");

            // Get the width and height of the image
            int ws = img.Width;
            int hs = img.Height;

            // Create an instance of ImgUnwrapper with image dimensions
            ImgUnwrapper unwrapper = new ImgUnwrapper(configFilePath, ws, hs);

            // Unwarp the image
            Mat unwarpedImg = unwrapper.Unwarp(img);

            // Display the images
            // Cv2.ImShow("Original Image", img);
            Cv2.ImShow("Unwarped Image", unwarpedImg);
            Cv2.WaitKey(0);

            Console.WriteLine("Program completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

