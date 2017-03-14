﻿using NetPrints.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPrints.Graph
{
    public class LiteralNode : Node
    {
        public NodeOutputDataPin ValuePin
        {
            get { return OutputDataPins[0]; }
        }

        public Type LiteralType { get; private set; }

        public object Value
        {
            get
            {
                return val;
            }
            set
            {
                if (value.GetType() != LiteralType)
                {
                    throw new ArgumentException("Value is not of the same type as LiteralType");
                }

                val = value;
            }
        }

        private object val;

        public LiteralNode(Method method, Type literalType, object value)
            : base(method)
        {
            LiteralType = literalType;
            Value = value;

            AddOutputDataPin("Value", literalType);
        }

        public override string ToString()
        {
            return $"{LiteralType.Name}";
        }
    }
}
