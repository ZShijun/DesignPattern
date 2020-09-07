﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy3
{
    public class Graphics
    {
        private IStrokeStrategy _strokeStrategy;
        private IFillStrategy _fillStrategy;
        
        public Graphics(IStrokeStrategy strokeStrategy,
                        IFillStrategy fillStrategy)
        {
            this._strokeStrategy = strokeStrategy;
            this._fillStrategy = fillStrategy;
        }

        public void SetStrokeStrategy(IStrokeStrategy strokeStrategy)
        {
            this._strokeStrategy = strokeStrategy;
        }

        public void Stroke()
        {
            this._strokeStrategy.Stroke();
        }
        
        public void Fill()
        {
            this._fillStrategy.Fill();
        }
    }
}
