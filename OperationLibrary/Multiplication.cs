﻿
namespace OperationLibrary
{
    public class Multiplication : Operation
    {
        public Multiplication()
        {
            Priority = 2;
            Arity = 2;
            Type = Type.Infix;
            Commutativity = true;
            Symbol = "*";
            Group = Group.Arithmetic;
        }

        public override decimal Execute(params decimal[] operands)
        {
            return operands[0] * operands[1];
        }
    }
}
