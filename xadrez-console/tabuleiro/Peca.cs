﻿using xadrez_console.tabuleiro.Enum;
namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca()
        {
        }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;            
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }
    }
}
