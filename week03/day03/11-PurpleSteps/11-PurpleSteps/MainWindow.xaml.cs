﻿using System;
using System.Windows;
using GreenFox;
using System.Windows.Media;


namespace _11_PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random random = new Random();

            double x = 20;
            double y = 20;

            for (int i = 0; x < canvas.Width / 3 * 2; i++)
            {
               for (int j = 0; y < canvas.Height / 3 * 2; i++)
               {
                    foxDraw.FillColor(RandomColor(random));
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.DrawRectangle(x, y, 20, 20);
                    x += 20;
                    y += 20;
                }
            }
        }
        public Color RandomColor(Random random)
        {
            return Color.FromArgb((byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255),
                                 (byte)random.Next(255));
        }
    }
}
