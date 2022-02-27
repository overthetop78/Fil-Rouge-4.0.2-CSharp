using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;


namespace Fil_Rouge_4._0._2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* Fil Rouge */
            // Totaux
            TotalShape totalShape = new TotalShape();
            TotalVolume volumeTotal = new TotalVolume();

            // Rectangle
            Rectangle rect1 = new Rectangle();
            Console.WriteLine(rect1.GetResult());
            Console.WriteLine("---------------------------");
            Rectangle rect2 = new Rectangle(65, 80);
            Console.WriteLine(rect2.GetResult());

            Console.WriteLine("___________________________________________");
            // // Triangle
            Triangle tri1 = new Triangle();
            Console.WriteLine(tri1.GetResult());
            Console.WriteLine("---------------------------");
            Triangle tri2 = new Triangle(20, 3.90, 20.20);
            Console.WriteLine(tri2.GetResult());
            Console.WriteLine("---------------------------");
            Triangle tri3 = new Triangle(56, 25, 42);
            Console.WriteLine(tri3.GetResult());
            Console.WriteLine("___________________________________________");
            // // Cercle
            Cercle cer1 = new Cercle();
            Console.WriteLine(cer1.GetResult());
            Console.WriteLine("---------------------------");
            Cercle cer2 = new Cercle(56);
            Console.WriteLine(cer2.GetResult());
            Console.WriteLine("___________________________________________");
            // Form
            Shape formRect = new Rectangle(50, 50);
            Console.WriteLine(formRect.GetResult());
            Console.WriteLine("---------------------------");
            Shape formCercle = new Cercle(50);
            Console.WriteLine(formCercle.GetResult());
            Console.WriteLine("---------------------------");
            Shape formTri = new Triangle(35, 56, 73);
            Console.WriteLine(formTri.GetResult());
            Console.WriteLine("___________________________________________");

            // Calcul des Aires
            totalShape.AddShapeToList(rect1);
            totalShape.AddShapeToList(rect2);
            totalShape.AddShapeToList(tri1);
            totalShape.AddShapeToList(tri2);
            totalShape.AddShapeToList(tri3);
            totalShape.AddShapeToList(cer1);
            totalShape.AddShapeToList(cer2);
            totalShape.AddShapeToList(formRect);
            totalShape.AddShapeToList(formCercle);
            totalShape.AddShapeToList(formTri);

            // Affichage des Calculs 
            Console.WriteLine(totalShape.GetResult());
            Console.WriteLine("___________________________________________");

            // Parallélèpipède
            Console.WriteLine("Parallélépipèdes");
            Shape3D paral1 = new Shape3D(rect1, 15);
            Console.WriteLine(paral1.GetResult());
            Console.WriteLine("---------------------------");
            Shape3D paral2 = new Shape3D(rect2, 100);
            Console.WriteLine(paral2.GetResult());
            Console.WriteLine("---------------------------");

            // Pyramide
            Console.WriteLine("Pyramides");
            Shape3D pyra1 = new Shape3D(tri1, 10);
            Console.WriteLine(pyra1.GetResult());
            Console.WriteLine("---------------------------");
            Shape3D pyra2 = new Shape3D(tri2, 20);
            Console.WriteLine(pyra2.GetResult());
            Console.WriteLine("---------------------------");
            Shape3D pyra3 = new Shape3D(tri3, 1);
            Console.WriteLine(pyra3.GetResult());
            Console.WriteLine("---------------------------");

            // Sphère
            Console.WriteLine("Sphères");
            Shape3D sphere1 = new Shape3D(cer1, 10);
            Console.WriteLine(sphere1.GetResult());
            Console.WriteLine("---------------------------");
            Shape3D sphere2 = new Shape3D(cer2, 100);
            Console.WriteLine(sphere2.GetResult());

            // Total Volumes

            volumeTotal.AddShape3DToList(paral1);
            volumeTotal.AddShape3DToList(paral2);
            volumeTotal.AddShape3DToList(pyra1);
            volumeTotal.AddShape3DToList(pyra2);
            volumeTotal.AddShape3DToList(pyra3);
            volumeTotal.AddShape3DToList(sphere1);
            volumeTotal.AddShape3DToList(sphere2);
            Console.WriteLine("___________________________________________");
            Console.WriteLine(volumeTotal.GetResult());



            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

}
