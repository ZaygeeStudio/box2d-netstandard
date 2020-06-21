﻿/*
    Window Simulation Copyright © Ben Ukhanov 2020
*/

using Box2D.NetStandard.Common;
using Box2D.NetStandard.Dynamics;
using Box2D.NetStandard.Dynamics.World;
using Box2D.NetStandard.Dynamics.World.Callbacks;
using Color = Box2D.NetStandard.Dynamics.World.Color;

namespace Box2D.Window
{
    public class DrawPhysics : DebugDraw
    {
        private readonly IWindow window;

        public DrawPhysics(IWindow window)
        {
            this.window = window;
        }

        public override void DrawPolygon(Vec2[] vertices, int vertexCount, Color color)
        {
            window.DrawPolygon(vertices, vertexCount, color);
        }

        public override void DrawSolidPolygon(Vec2[] vertices, int vertexCount, Color color)
        {
            window.DrawSolidPolygon(vertices, vertexCount, color);
        }

        public override void DrawCircle(Vec2 center, float radius, Color color)
        {
            window.DrawCircle(center, radius, color);
        }

        public override void DrawSolidCircle(Vec2 center, float radius, Vec2 axis, Color color)
        {
            window.DrawSolidCircle(center, radius, axis, color);
        }

        public override void DrawSegment(Vec2 p1, Vec2 p2, Color color)
        {
            window.DrawSegment(p1, p2, color);
        }

        public override void DrawXForm(Transform xf)
        {
            window.DrawXForm(xf);
        }
    }
}