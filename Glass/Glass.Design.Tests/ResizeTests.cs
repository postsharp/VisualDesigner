﻿using System.Windows;
using Glass.Design.Pcl.Canvas;
using Glass.Design.Pcl.Core;
using Glass.Design.Pcl.DesignSurface.VisualAids.Resize;
using Glass.Design.Pcl.DesignSurface.VisualAids.Snapping;
using Glass.Design.Wpf.Core;
using ImpromptuInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ResizeTests
    {

        static ResizeTests()
        {
            ServiceLocator.CoreTypesFactory = new CoreTypesFactoryWpf();
        }

        [TestMethod]
        public void IncreaseWidthTopRight()
        {
            var canvasItem = new CanvasModelItem
                             {
                                 Width = 30,
                                 Height = 30,
                                 Left = 10,
                                 Top = 20,
                             };

            var hookPoint = new Point(40, 20).ActLike<IPoint>();
            var newPoint = new Point(50, 20).ActLike<IPoint>();

            var resizeOperation = new ResizeOperation(canvasItem, newPoint , new NoEffectsCanvasItemSnappingEngine());
            resizeOperation.UpdateHandlePosition(newPoint);
            Assert.AreEqual(40D, canvasItem.Width);
        }

    }
}