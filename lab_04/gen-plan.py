import math
import locale
locale.setlocale(locale.LC_ALL, '')


col_names = ['x1', 'x2', 'x3', 'x4', 'x5', 'x6', 'x7', 'x8']
col_sqr_names = ['x1x1', 'x2x2', 'x3x3', 'x4x4', 'x5x5', 'x6x6', 'x7x7', 'x8x8']
matrix = []

n = 8
k = 4

n_ffd = 2 ** (n - k)
n_sp = 2 * n
n_c = 1
n_sum = n_ffd + n_sp + n_c

a = math.sqrt(n_ffd / n_sum)
alpha = math.sqrt(0.5 * (math.sqrt(n_ffd * n_sum) - n_ffd))

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

# col x_0
col = []
for i in range(n_sum):
    col.append(1)
matrix.append(col)

# col x_1
col = []
for i in range(n_ffd // 2):
    col.append(-1)
    col.append(1)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 2):
    col.append(0)
col.append(0)
matrix.append(col)

col = [] # col x_2
for i in range(n_ffd // 4):
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 4):
    col.append(0)
col.append(0)
matrix.append(col)

col = [] # col x_3
for i in range(n_ffd // 8):
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(-1)
    col.append(1)
    col.append(1)
    col.append(1)
    col.append(1)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 6):
    col.append(0)
col.append(0)
matrix.append(col)

col = [] # col x_4
for i in range(n_ffd // 16):
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
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 8):
    col.append(0)
col.append(0)
matrix.append(col)

col = []
for i in range(n_ffd): # x5=x1x2x3
    col.append(matrix[1][i] * matrix[2][i] * matrix[3][i])
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 10):
    col.append(0)
col.append(0)
matrix.append(col)

col = []
for i in range(n_ffd): # x6=x1x2x4
    col.append(matrix[1][i] * matrix[2][i] * matrix[4][i])
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 12):
    col.append(0)
col.append(0)
matrix.append(col)

col = []
for i in range(n_ffd): # x7=x1x3x4
    col.append(matrix[1][i] * matrix[3][i] * matrix[4][i])
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 14):
    col.append(0)
col.append(0)
matrix.append(col)

col = []
for i in range(n_ffd): # x8=x2x3x4
    col.append(matrix[2][i] * matrix[3][i] * matrix[4][i])
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(0)
col.append(-alpha)
col.append(alpha)
for i in range(n_sp - 16):
    col.append(0)
col.append(0)
matrix.append(col)

for i in range(n + 1, len(col_names)):
    indices = col_names[i].split('x')
    col = []

    for j in range(n_sum):
        res = 1

        for k in range(1, len(indices)):
            res *= matrix[int(indices[k])][j]
        
        col.append(res)

    matrix.append(col)

col_names = col_names[:n_sum - n] + col_sqr_names

for i in range(len(col_sqr_names)):
    index = int(col_sqr_names[i][1])
    col = []

    for j in range(n_sum - 1):
        col.append(matrix[index][j] ** 2 - a)

    col.append(0)
    matrix.append(col)

with open('ocp.csv', 'w', encoding='utf-16') as f:
    line = 'N;'
    line += ';'.join(col_names)
    f.write(f'{line};Y ф.;Y нел.;Y ф. - Y нел.;(Y ф. - Y лин.)^2\n')

    for i in range(n_sum):
        line = f'{i + 1};'
        for j in range(n_sum - 8):
            line += '{:,};'.format(matrix[j][i]).replace('.', ',')
        for j in range(len(matrix) - 8, len(matrix)):
            line += '{:,};'.format(matrix[j][i]).replace('.', ',')
        f.write(f'{line}\n')
