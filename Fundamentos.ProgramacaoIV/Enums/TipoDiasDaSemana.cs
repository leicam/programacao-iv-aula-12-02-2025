using System.ComponentModel;

namespace Fundamentos.ProgramacaoIV.Enums;

[Flags]
internal enum TipoDiasDaSemana
{
    [Description("Nao identificado")]
    NaoIdentificado = 0,

    [Description("Domingo")]
    Domingo = 1,

    [Description("Segunda-feira")]
    Segunda = 2,

    [Description("Terça-feira")]
    Terca = 4,

    [Description("Quarta-feira")]
    Quarta = 8,

    [Description("Quinta-feira")]
    Quinta = 16,

    [Description("Sexta-feira")]
    Sexta = 32,

    [Description("Sábado")]
    Sabado = 64
}