# unity-mlagents-Snakes


SampleScene.unity is the scene
Move .cs is a script
ball.yaml is the configuration for training
ball.onnx is the trained model

1.Install Anaconda
2.Open Anaconda Prompt
conda create -n base1 python=3.8
conda activate base1
pip install torch~=1.7.1
cd xxxxxxxxxxxx\ml-agents-release_19
pip install -e./ml-agents-envs
pip install -e./ml-agents
pip uninstall protobuf
pip install protobuf==3.19.6
pip uninstall numpy
pip install numpy==1.19
cd xxxxxxxxxxxx\Train
mlagents-learn ball.yaml --runid-id=01
