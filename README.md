# unity-mlagents-Snakes


conda env list  
conda create -n  base1 python=3.8  
conda activate base1  
cd C:\Users\546546\Desktop\ml-agents-release_19\ml-agents-release_19  
pip install torch~=1.7.1  
pip install -e./ml-agents-envs  
pip install -e./ml-agents  
pip uninstall protobuf  
pip install protobuf==3.19.6  
pip uninstall numpy  
pip install numpy==1.19  
mlagents-learn config/ppo/ball.yaml --run-id=t1  
conda remove -n base1 --all  

