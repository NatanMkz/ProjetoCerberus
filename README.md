Não estou muito satisfeito com alguns softwares de SIEM que eu utilizei, portanto decidi criar o meu próprio, como eu ainda não pensei em um nome apropriado, decidi adotar o nome do cão de três cabeças que é guardião do submundo na mitologia grega

Algumas coisas que eu gostaria de ampliar nesse projeto:

* Vinculo direto com algumas bibliotecas de GEOIP como Censys e Shodan, para pesquisa da origem do tráfego.
* Análise Avançada de Comportamento de Usuário.
* Módulo de Gestão de Vulnerabilidades (algo como Mitre Att8ck Framework).
* Monitoramento de API em Microserviço.
* Detecção de Ransomware.

  Eu entendo que o sentinel ja usa o MitreAtt8ck mas a biblioteca parece estar desatualizado em relação aos malwares de 2024 e novas descobertas de CVE's. Seria muito util também, uma ferramenta para detectar o Ransomwares.


  Limitações: custos de nuvem e performance de analise. O Sentinel possui o KQL para os Logs, vai ser meio dificil de lidar com a performance de milhões de pacotes ou milhões de linhas de logs da camada de aplicação, mas a ideia para lidar com isso é otimização de código
  usando técnicas aprendidas nas matérias de Complexidade de Algoritmos.
