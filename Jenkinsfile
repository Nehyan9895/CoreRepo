pipeline {
    agent any
    stages {
        stage('Pull Changes') {
            steps {
                sh 'git pull origin main'
            }
        }
        stage('Build DLLs') {
            steps {
                sh 'dotnet build'
            }
        }
        stage('Sync DLLs') {
            steps {
                sh 'python3 ../sync_repos.py CoreRepo'
            }
        }
        stage('Run Tests') {
            steps {
                sh 'dotnet test CoreRepoTest'
            }
        }
        stage('Push Changes') {
            steps {
                sh '''
                git add .
                git commit -m "Synced DLLs"
                git push origin main
                '''
            }
        }
    }
}
