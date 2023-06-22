# unity-mlagents-Snakes


conda env list  
conda create -n base4 python=3.8  
conda activate base4 
pip install torch~=1.7.1
cd C:\Users\546546\Desktop\ml-agents-release_19\ml-agents-release_19
pip install -e./ml-agents-envs
pip install -e./ml-agents
pip uninstall protobuf
pip install protobuf==3.19.6
pip uninstall numpy
pip install numpy==1.19
cd C:\Users\546546\Desktop\project\unityTrain\Assets\Train
mlagents-learn ball.yaml --runid-id=01

