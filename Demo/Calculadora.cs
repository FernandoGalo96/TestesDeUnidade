﻿namespace Demo;

public class Calculadora
{
    public double Somar(double v1, double v2)
    {
        return v1 + v2;
    }

    public double Dividir(double v1, double v2)
    {
        if (v2 == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return v1 / v2;
    }
}
