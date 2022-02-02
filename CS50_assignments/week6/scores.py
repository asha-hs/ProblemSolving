from cs50 import get_int

scores = []
for i in range(3):
    score = get_int("score:")
    scores.append(score)

avg = sum(scores) / len(scores)
print(avg)