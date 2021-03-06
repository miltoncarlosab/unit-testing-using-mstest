﻿using Domain;
using System.Collections.Generic;

namespace Service.Pessoas
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> ObterPessoasAtivas();
        IEnumerable<Pessoa> ObterPessoasPorNomeAtivas(string nome);
        bool PessoaAtivaParaSistema(long id);
    }
}
