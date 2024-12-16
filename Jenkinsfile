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
        stage('Run Synchronization') {
            steps {
                sh 'python3 ../sync_repos.py'
            }
        }
        stage('Push Changes') {
            steps {
                sh '''
                git add .
                git commit -m "Sync updated DLLs"
                git push origin main
                '''
            }
        }
    }
}
