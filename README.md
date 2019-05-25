# AssociadoDePlantao
Programa em C# para gerenciamento de entrada e saída de funcionários

## Cenário do Projeto
Considere o seguinte cenário: "A empresa Associados de Plantão precisa de um software para controlar a entrada e saída de seus funcionários em determinadas salas, pois os arquivos existentes nelas são sigilosos. O gerente irá cadastrar os funcionários que possuem esta permissão e quais salas ele irá permitir a entrada. O funcionário ao chegar a porta desta sala irá acessar o sistema com seu login e senha e informar o código da sala que deseja entrar para que a porta se abra. O sistema deve emitir avisos: avisar ao funcionário se login e senha estão corretos, se foi permitida a entrada, se não foi permitida, entre outros. Outro ponto importante é que o sistema deverá bloquear a senha na terceira tentativa avisando ao funcionário que deverá procurar o administrador do sistema para restaurar a senha. Por fim a empresa possui diversas filiais."

## Requesitos Funcionais
- RF1 Cadastrar loja: O sistema deve permitir cadastrar, editar, buscar e excluir dados das lojas.
- RF2 Cadastrar funcionário: O sistema deve permitir cadastrar, editar, buscar e excluir dados dos funcionários.
- RF3 Cadastrar salas: O sistema deve permitir cadastrar, editar, buscar e excluir dados das salas.  
- RF4 Cadastrar gerente: O sistema deve permitir cadastrar dados dos funcionários.
- RF5 Realizar login: O sistema deve permitir que o funcionário insira  seu login, senha e sala onde deseja entrar. 
Caso os dados estejam corretos, os sistema emite uma mensagem indicando que o funcionário pode entrar e registra data e hora do acesso.  
Caso os dados estejam incorretos o sistema irá mostra uma mensagem de erro e informar quantas vezes o funcionário errou sua senha. 
Se a quantidade de erros ultrapassar 3 vezes em sequência, o sistema bloqueia emitindo uma mensagem para que o funcionário procure o seu administrador.  
- RF6 Restaurar senha: O sistema permite que o administrador restaure a senha dos funcionários.

## Utilização Correta
- Execute o programa através do Visual Studio
- Execute o script do Banco de Dados 
- Na classe "AcessoBD" altere o nome do servidor SQL
