﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media.Media3D;

namespace _3DReconstructionWPF.Data
{
    class BBox
    {

        private Point3D _maxPoint;
        private Point3D _minPoint;

        public BBox()
        {
            _maxPoint = new Point3D();
            _minPoint = new Point3D();
        }

        public void Extend(Point3D p)
        {
            double x = p.X;
            double y = p.Y;
            double z = p.Z;

            if (x > _maxPoint.X) _maxPoint.X = x;
            else if (x < _minPoint.X) _minPoint.X = x;

            if (y > _maxPoint.Y) _maxPoint.Y = y;
            else if (y < _minPoint.Y) _minPoint.Y = y;

            if (z > _maxPoint.Z) _maxPoint.Z = z;
            else if (z < _minPoint.Z) _minPoint.Z = z;
        }

        public Point3D GetMaxPoint()
        {
            return _maxPoint;
        }

        public Point3D GetMinPoint()
        {
            return _minPoint;
        }
    }
}