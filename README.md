The problem statement for Kattis texture analysis is as follows:

A texture is a two-dimensional pattern that is visible on some surface. A common example of a texture is the pattern on a bathroom wall. A texture can be described by a two-dimensional pattern of characters. For example, the following pattern can be used to describe the bathroom wall:

```
*..*..*..*..*..*
.*..*..*..*..*..
*..*..*..*..*..*
.*..*..*..*..*..
```

A texture is called even if the distance between every pair of adjacent asterisks `*` is the same in each row and column. For example, the texture above is even, but the texture below is not:

```
**.*.*.*.*
*.**.*.*.*
**.*.*.*.*
*.**.*.*.*
```

Your task is to write a program that reads a number of textures and for each one decides whether it is even or not³.
