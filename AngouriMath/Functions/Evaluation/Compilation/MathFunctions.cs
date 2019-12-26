﻿using AngouriMath.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngouriMath
{
    internal static class CompiledMathFunctions
    {
        internal static readonly Dictionary<string, int> func2Num = new Dictionary<string, int>
        {
            { "sumf", 0 },
            { "minusf", 1 },
            { "mulf", 2 },
            { "divf", 3 },
            { "powf", 4 },
            { "sinf", 5 },
            { "cosf", 6 },
            { "logf", 7 },
        };

        internal delegate void CompiledFunction(Stack<Number> stack);
        internal static readonly CompiledFunction[] functions =
            new CompiledFunction[]
            {
                Sumf,
                Minusf,
                Mulf,
                Divf,
                Powf,
                Sinf,
                Cosf,
                Logf
            };

        internal static readonly Number[] buffer = new Number[10];

        internal static void Sumf(Stack<Number> stack)
        {
            Number n1 = stack.Pop();
            Number n2 = stack.Pop();
            stack.Push(n1 + n2);
        }
        internal static void Minusf(Stack<Number> stack)
        {
            Number n1 = stack.Pop();
            Number n2 = stack.Pop();
            stack.Push(n1 - n2);
        }
        internal static void Mulf(Stack<Number> stack)
        {
            Number n1 = stack.Pop();
            Number n2 = stack.Pop();
            stack.Push(n1 * n2);
        }
        internal static void Divf(Stack<Number> stack)
        {
            Number n1 = stack.Pop();
            Number n2 = stack.Pop();
            stack.Push(n1 / n2);
        }
        internal static void Powf(Stack<Number> stack)
        {
            Number n1 = stack.Pop();
            Number n2 = stack.Pop();
            stack.Push(Number.Pow(n1, n2));
        }
        internal static void Sinf(Stack<Number> stack)
        {
            Number n = stack.Pop();
            stack.Push(Number.Sin(n));
        }
        internal static void Cosf(Stack<Number> stack)
        {
            Number n = stack.Pop();
            stack.Push(Number.Cos(n));
        }
        internal static void Logf(Stack<Number> stack)
        {
            Number n1 = stack.Pop();
            Number n2 = stack.Pop();
            stack.Push(Number.Log(n1, n2));
        }
    }
}