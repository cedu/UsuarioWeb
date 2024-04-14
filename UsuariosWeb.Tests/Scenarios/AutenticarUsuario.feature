#language: pt

Funcionalidade: Autenticar usuário
	Como um usuário do sistema
	Eu quero acessar minha conta de usuário
	Para que eu possa usar os recursos do sistema

Cenário: Autenticar usuário com sucesso
	Dado Acessar a página de autenticação de usuários
	E Informar o email "administrador@test.com"
	E Informar a senha "@Test123"
	Quando Solicitar o acesso ao sistema
	Então Sistema autentica o usuário com sucesso

Cenário: Acesso negado
	Dado Acessar a página de autenticação de usuários
	E Informar email e senha inválidos
	Quando Solicitar o acesso ao sistema
	Então Sistema informa que o acesso é negado