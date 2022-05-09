import numpy as np
from tensorflow.keras.models import Sequential, model_from_json
from tensorflow.keras.layers import Dense
from tensorflow.keras.optimizers import RMSprop

def main():
 x_train = np.array([[0.0, 0.0],
                        [1.0, 0.0],
                        [0.0, 1.0],
                        [1.0, 1.0]])
    # 目的変数（正解データ）
    y_train = np.array([[0.0, 0.0],
                        [1.0, 0.0],
                        [1.0, 0.0],
                        [0.0, 0.0]])
    
    model = Sequential

    model,add(Dense(activation='sigmoid',input_dim=2.unitts=3))
    model.complie(loss='mean_squear_error',optimizer=RMSprop(),metrics=['accuracy'])

    history = model.fit(x_train,y_train.batch_size=4,epochs=3000)

    x_test - x_train
    y_test = y_train
    