from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.neighbors import KNeighborsClassifier
from sklearn.metrics import accuracy_score
import matplotlib.pyplot as plt
from sklearn.naive_bayes import GaussianNB
from sklearn.svm import SVC
from tensorflow.keras.models import Sequential
from tensorflow.keras.utils import to_categorical
from tensorflow.keras.layers import Dense
from sklearn.metrics import confusion_matrix
iris = load_iris()
# print(iris)
x = iris['data']
y = iris['target']
print(x[100])
print(y[100])
sc = StandardScaler()
x = sc.fit_transform(x)
print(x[100])

x_train, x_test, y_train, y_test = train_test_split(x, y, train_size= 0.8, random_state=42)
print(len(x_train))
print(len(x_test))
print(len(y_train))
print(len(y_test))
model = KNeighborsClassifier(n_neighbors=3)
model.fit(x_train, y_train)
preds = model.predict(x_test)
print(preds)

model_knn_5 = KNeighborsClassifier(n_neighbors=5)
model_knn_5.fit(x_train, y_train)
preds_knn_5 = model_knn_5.predict(x_test)
print(accuracy_score(y_test, preds))

acc_scores = []
for i in range(1,20):
    model = KNeighborsClassifier(i)
    model.fit(x_train, y_train)
    model.fit(x_train, y_train)
    preds = model.predict(x_test)
    acc_scores.append(accuracy_score(y_test, preds))

k_range = list(range(1,20))
print(k_range)
plt.plot(k_range, acc_scores)
plt.show()


model = GaussianNB()
model.fit(x_train, y_train)
preds = model.predict(x_test)
print(accuracy_score(y_test, preds))

model = SVC()
model.fit(x_train, y_train)
preds = model.predict(x_test)
print(accuracy_score(y_test, preds))

print(confusion_matrix(y_test, preds))
print(iris['target_names'])

model = Sequential()
model.add(Dense(32, activation='relu'))
model.add(Dense(16, activation='relu'))
model.add(Dense(8, activation='relu'))
model.add(Dense(3, activation='softmax'))

model.compile(optimizer='adam', loss='categorical_crossentropy', metrics=['accuracy'])
model.fit()