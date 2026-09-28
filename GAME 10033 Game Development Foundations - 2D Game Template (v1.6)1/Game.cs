// Include the namespaces (code libraries) you need below.
using MohawkGame2D;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
        
    {
        float x1;
        float x2;
        float x3;
        float y1;
        float y2;
        float y3;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Set the window title for program window
            Window.SetTitle("Ball of Light");

            // Set the window size to 400x400 pixels
            Window.SetSize(400, 400);
            // Aim to render 60 times a second (60 FPS)
            Window.TargetFPS = 60;
            // Set the background color to an off-white color
            Window.ClearBackground(240);


            Draw.SetFillColor(0, 225, 255); // Set fill color to light blue
            Draw.SetLineColor(0, 225, 255); // Set line color to light blue

            // Draw Circle at XY position (200, 200) with a radius of 35 pixels
            Draw.Circle(200, 200, 35); 
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear previous image with off-white background color
            Window.ClearBackground(240);
            // Get mouse position
            float mouseX = Input.GetMouseX();
            float mouseY = Input.GetMouseY();
            //
            x3 = x2;
            y3 = y2;
            //
            x2 = x1;
            y2 = y1;

            x1 = mouseX;
            y1 = mouseY;

            // Draw shadow 3
            Draw.SetFillColor(0, 0, 0, 128); // Set fill color to semi-transparent black
            Draw.SetLineColor(0, 0, 0, 128); // Set line color to semi-transparent black
            Draw.Circle(x3 + 5, y3 + 5, 35); // Draw shadow circle at slightly offset position

            // Draw shadow 2
            Draw.SetFillColor(0, 0, 0, 64); // Set fill color to more transparent black
            Draw.SetLineColor(0, 0, 0, 64); // Set line color to more transparent black
            Draw.Circle(x2 + 2, y2 + 2, 35); // Draw shadow circle at slightly offset position

            // Draw shadow 1
            Draw.SetFillColor(0, 0, 0, 32); // Set fill color to even more transparent black
            Draw.SetLineColor(0, 0, 0, 32); // Set line color to even more transparent black
            Draw.Circle(x1, y1, 35); // Draw shadow circle at mouse position

            // Draw mouse
            Draw.SetFillColor(0);
            Draw.Circle(mouseX, mouseY, 5); // Draw small black circle at mouse position

            // Circle is light blue
            Draw.SetFillColor(0, 225, 255);
            Draw.SetLineColor(0, 225, 255);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 35); // Draw Circle at mouse position with a radius of 35 pixels)
            
        }
    }

}
