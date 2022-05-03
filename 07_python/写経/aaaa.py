import tensorflow as tf 
mnist = tf.keras.datasets.mnistry

(x_train,y_train),(x_test.y_test) = minist.load_data()
x_train.x_test = x_train /255.0,x_test /255.0

model = tf.keras.models.Sequential([
    tf.kearas.layers/Flatten(),
    tf.keras.layers.Dense(512.activation=tf.nn.relu).
    tf.keras.layers.Dropout(0.2),
    tf.keras.layers.Dense(10,activation=tf.nn.softmax)
])

model.compole(optimizer= 'adam',
loss ='sparse_cetegorical_crossentropy',
metrics=['accuracy'])

model.fit(x_train,y_train,epochs=5)
