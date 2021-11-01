# CreateHashFile
Criar hash de arquivos

# Exemplo de Implementação
Para Sha1:
```
var hash = CreateHashFile.ObterHashDoArquivo(TipoDeHash.Hash.SHA1, @"C:\Users\raete\Desktop\teste\teste.txt");
```

Para MD5:
```
var hash = CreateHashFile.ObterHashDoArquivo(TipoDeHash.Hash.MD5, @"C:\Users\raete\Desktop\teste\teste.txt");
```

