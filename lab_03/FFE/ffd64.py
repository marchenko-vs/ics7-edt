col_names = ['x1', 'x2', 'x3', 'x4', 'x5', 'x6', 'x7', 'x8']
matrix = []
n = 8

for i in range(n - 1):
    for j in range(i + 1, n):
        new_name = f'{col_names[i]}{col_names[j]}'
        col_names.append(new_name)

for i in range(n - 2):
    for j in range(i + 1, n - 1):
        for k in range(j + 1, n):
            new_name = f'{col_names[i]}{col_names[j]}{col_names[k]}'
            col_names.append(new_name)

for i in range(n - 3):
    for j in range(i + 1, n - 2):
        for k in range(j + 1, n - 1):
            for l in range(k + 1, n):
                new_name = f'{col_names[i]}{col_names[j]}{col_names[k]}{col_names[l]}'
                col_names.append(new_name)

for i in range(n - 4):
    for j in range(i + 1, n - 3):
        for k in range(j + 1, n - 2):
            for l in range(k + 1, n - 1):
                for m in range(l + 1, n):
                    new_name = f'{col_names[i]}{col_names[j]}{col_names[k]}{col_names[l]}{col_names[m]}'
                    col_names.append(new_name)

for i in range(n - 5):
    for j in range(i + 1, n - 4):
        for k in range(j + 1, n - 3):
            for l in range(k + 1, n - 2):
                for m in range(l + 1, n - 1):
                    for o in range(m + 1, n):
                        new_name = f'{col_names[i]}{col_names[j]}{col_names[k]}{col_names[l]}{col_names[m]}{col_names[o]}'
                        col_names.append(new_name)

for i in range(n - 6):
    for j in range(i + 1, n - 5):
        for k in range(j + 1, n - 4):
            for l in range(k + 1, n - 3):
                for m in range(l + 1, n - 2):
                    for o in range(m + 1, n - 1):
                        for p in range(o + 1, n):
                            new_name = f'{col_names[i]}{col_names[j]}{col_names[k]}{col_names[l]}{col_names[m]}{col_names[o]}{col_names[p]}'
                            col_names.append(new_name)

for i in range(n - 7):
    for j in range(i + 1, n - 6):
        for k in range(j + 1, n - 5):
            for l in range(k + 1, n - 4):
                for m in range(l + 1, n - 3):
                    for o in range(m + 1, n - 2):
                        for p in range(o + 1, n - 1):
                            for r in range(p + 1, n):
                                new_name = f'{col_names[i]}{col_names[j]}{col_names[k]}{col_names[l]}{col_names[m]}{col_names[o]}{col_names[p]}{col_names[r]}'
                                col_names.append(new_name)

col_names.insert(0, 'x0')
matrix = []

col = []
for i in range(256):
    col.append(1)
matrix.append(col)

col = []
for i in range(128):
    col.append(-1)
    col.append(1)
matrix.append(col)

col = []
for i in range(64):
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
matrix.append(col)

col = []
for i in range(32):
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
matrix.append(col)

col = []
for i in range(16):
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
matrix.append(col)

col = []
for i in range(8):
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
matrix.append(col)

col = []
for i in range(4):
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
matrix.append(col)

col = []
for i in range(256): # x7=x1x2x3x4x5
    col.append(matrix[1][i] * matrix[2][i] * matrix[3][i] * matrix[4][i] * 
               matrix[5][i])
matrix.append(col)

col = []
for i in range(256): # x8=x1x2x3x4x6
    col.append(matrix[1][i] * matrix[2][i] * matrix[3][i] * matrix[4][i] * 
               matrix[6][i])
matrix.append(col)

# col = []
# for i in range(256): # x7=x1x2
#     col.append(matrix[1][i] * matrix[2][i])
# matrix.append(col)

# col = []
# for i in range(256): # x8=x3x4
#     col.append(matrix[3][i] * matrix[4][i])
# matrix.append(col)

for i in range(n + 1, len(col_names)):
    indices = col_names[i].split('x')
    new_col = []

    for j in range(256):
        res = 1

        for k in range(1, len(indices)):
            res *= matrix[int(indices[k])][j]
        
        new_col.append(res)

    matrix.append(new_col)

with open('ffd64.csv', 'w', encoding='utf-16') as f:
    line = 'N,'
    line += ','.join(col_names[:64])
    f.write(f'{line},Y ф.,Y лин.,Y ф. - Y лин.,Y ч.-н.,Y ф. - Y ч.-н.\n')

    for i in range(64):
        line = f'{i + 1},'
        for j in range(64):
            line += f'{matrix[j][i]},'
        f.write(f'{line}\n')
