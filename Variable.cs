﻿using System;

namespace Barbar.SymbolicMath
{
    /// <summary>
    /// Represents variable (unknown) in equations
    /// </summary>
    public class Variable : SymMathNode
    {
        /// <summary>
        /// Symbol representing this variable. Variables with same symbol are considered equal
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="symbol"></param>
        public Variable(string symbol)
        {
            Symbol = symbol;
        }

        /// <summary>
        /// Clone variable
        /// </summary>
        /// <returns></returns>
        public override SymMathNode Clone()
        {
            return new Variable(Symbol);
        }

        /// <summary>
        /// Throws an exception - can't evaluate a variable
        /// </summary>
        /// <returns></returns>
        public override double Evaluate()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// True if equal to variable represented by the same symbol
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public override bool Equals(SymMathNode node)
        {
            var term = node as Variable;
            if (term != null)
            {
                return string.Equals(Symbol, term.Symbol, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}
