﻿// See https://aka.ms/new-console-template for more information
using Biblioteca.Domain.Models;

Console.WriteLine("Hello, World!");




Livro livro = new Livro();
livro.LivroId = 1;
livro.Titulo = "DDD - C#";

EmprestimoLivro emprestimo1 = new EmprestimoLivro();
emprestimo1.EmprestimoLivroId = 1;
emprestimo1.FuncionarioId = 1; // Jose
emprestimo1.AlunoId = 1; // Rinaldo
emprestimo1.LivroId = livro.LivroId; //"DDD - C#"
emprestimo1.DataEmprestimo = DateTime.Now; // 19/10/2022

EmprestimoLivro emprestimo2 = new EmprestimoLivro();
emprestimo2.EmprestimoLivroId = 2;
emprestimo2.FuncionarioId = 1; // Jose
emprestimo2.AlunoId = 1; // Rinaldo
emprestimo2.LivroId = livro.LivroId; //"DDD - C#"
emprestimo2.DataEmprestimo = DateTime.Now; // 25/10/2022

DevolucaoLivro devolucao1 = new DevolucaoLivro();
devolucao1.DevolucaoId = 2;



DevolucaoLivro devolucao2 = new DevolucaoLivro();

Tipo tipo1 = new Tipo();
tipo1.TipoId = 1;
tipo1.Descricao = "Funcionario";
Tipo tipo2 = new Tipo();
tipo2.TipoId = 2;
tipo2.Descricao = "Aluno";
Tipo tipo3 = new Tipo();
tipo3.TipoId = 3;
tipo3.Descricao = "Professor";


Pessoa pessoa = new Pessoa();
pessoa.Id = 1;
pessoa.Nome = "Rinaldo";
Pessoa pessoa2 = new Pessoa();
pessoa2.Id = 2;
pessoa2.Nome = "Marcos";


Pessoa_Tipo pessoa_Tipo = new Pessoa_Tipo();
pessoa_Tipo.PessoaId = pessoa.Id;
pessoa_Tipo.TipoId = tipo2.TipoId;
pessoa_Tipo.Ativo = true;