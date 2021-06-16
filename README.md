### Estudo-C#
Projeto Calculadora.
Esse projeto tem o intuito de testar os conhecimentos 
github e C#.

Comandos C#
No cmd digite os seguintes comandos

dotnet new console -o <nome do projeto>
logo após acesse a pasta
escolhe a IDE preferida e corre para o abraço.

Passo 1: 
Salvar o projeto no seu Github

#git config --global user.name <seu nome>
#git config --global user.email <seu email>

git init

git add .

git commit -m "Project created"

git remote add origin <seu endereço>
#adiciona o ssh
Gerar uma nova chave SSH
Abra Git Bash.

Cole o texto abaixo, substituindo o endereço de e-mail pelo seu GitHub.

$ ssh-keygen -t ed25519 -C "your_email@example.com"

git push -u origin main
