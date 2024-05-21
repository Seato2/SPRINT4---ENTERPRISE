INTEGRANTES:
RM96410
RM97172
RM96978
RM96727
RM96792







Sistema Java
Funcionalidade Principal:

Gestão de Cotações de Preços:
Autenticação: Login e logout de usuários.
Visualização de Cotações: Listagem das cotações de preços disponíveis.
Adição de Cotações: Formulário para adicionar novas cotações de preços.
Logout: Página simples de logout.
Componentes Chave:

Controladores:

CotacaoController: Gerencia as operações relacionadas às cotações.
HomeController: Gerencia a navegação da página inicial.
LoginController: Gerencia a autenticação dos usuários.
LogoutController: Gerencia o logout dos usuários.
Páginas HTML com Estilo Inline:

Home: Página inicial com links para visualizar cotações, adicionar cotações e logout.
Adicionar Cotação: Formulário para adicionar uma nova cotação.
Listar Cotações: Listagem de todas as cotações disponíveis.
Login: Página de login para autenticação do usuário.
Logout: Página de logout confirmando a saída do usuário.
Integração com C#
Funcionalidade Principal:

Encurtamento de URLs:
Um cliente C# que interage com o sistema Java para encurtar URLs.
Permite que URLs longas (como as URLs das cotações) sejam encurtadas e redirecionadas de volta para as URLs originais.
Componentes Chave:

Cliente C#:
Input da URL Longa: Solicita ao usuário uma URL longa para ser encurtada.
Encurtamento da URL: Envia a URL longa para o serviço de encurtamento e recebe uma URL curta.
Acesso à URL Curta: Acessa a URL curta e redireciona para a URL longa original.
Fluxo de Trabalho
Usuário interage com o sistema Java:

Faz login no sistema.
Visualiza e adiciona cotações de preços.
Faz logout do sistema.
Usuário utiliza o cliente C# para encurtar URLs:

Insere uma URL longa gerada pelo sistema Java.
Recebe uma URL curta que pode ser compartilhada.
Acessa a URL curta, que redireciona para a URL longa original.
