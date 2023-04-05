# CreateHashFile
Criar hash de arquivos

# Exemplo de Implementação
***Para Sha1:***
```
var hash = CreateHashFile.ObterHashDoArquivo(TipoDeHash.Hash.SHA1, @"teste.txt");
```

***Para MD5:***
```
var hash = CreateHashFile.ObterHashDoArquivo(TipoDeHash.Hash.MD5, @"teste.txt");
```

