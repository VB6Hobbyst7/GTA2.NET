// GTA2.NET
// 
// File: DiagonalFacingUpRight.cs
// Created: 22.04.2013
// Created by: João Pires
// 
// Copyright (C) 2010-2013 Hiale
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
// is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies
// or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR
// IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
// Grand Theft Auto (GTA) is a registred trademark of Rockstar Games.
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Hiale.GTA2NET.Core.Collision;

namespace Hiale.GTA2NET.Core.Map.Blocks
{
    public class DiagonalFacingUpRightBlock : DiagonalBlock
    {
        public DiagonalFacingUpRightBlock() : base() 
        {
            SlopeType = SlopeType.DiagonalFacingUpRight;
        }

        public DiagonalFacingUpRightBlock(BlockStructure blockStructure, Vector3 pos) : base(blockStructure, pos) 
        {
            SlopeType = SlopeType.DiagonalFacingUpRight;
        }
        
        public override void SetUpCube()
        {
            SetUpSlopeDiagonal(0);
        }

        public override void GetCollision(List<ILineObstacle> obstacles, bool bulletWall)
        {
            if (DoesWallCollide(Right, bulletWall))
                obstacles.Add(new LineObstacle(new Vector2(Position.X, Position.Y), new Vector2(Position.X + 1, Position.Y + 1), (int)Position.Z));
            if (DoesWallCollide(Bottom, bulletWall))
                obstacles.Add(GetDefaultBottomCollison());
            if (DoesWallCollide(Left, bulletWall))
                obstacles.Add(GetDefaultLeftCollison());
        }
    }
}
