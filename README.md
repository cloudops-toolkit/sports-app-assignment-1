# Sports Platform CI/CD Pipeline

## Overview
This project implements a CI/CD pipeline for a sports platform consisting of a .NET API and a React-based website. The infrastructure uses AWS services with GitHub Actions for automation.

## Architecture

### API Layer
- .NET 9.0 running on AWS ECS Fargate

### Frontend
- Next.js static site hosted on S3

### CI/CD
- GitHub Actions

### Infrastructure
- AWS (ECS, ECR, S3, CloudWatch)

## Features

### API Service
- .NET 9.0 Web API
- RESTful endpoints for sports data
- Health check endpoint
- CORS enabled
- Containerized with Docker

### Website
- Next.js static site
- React Query for data fetching
- Tailwind CSS for styling
- Responsive design

### CI/CD Pipeline Features
- Automated testing
- Docker image building and pushing
- Automatic rollback on failure
- Health monitoring
- Alert triggers

## Monitoring & Alerts

### CloudWatch Metrics
- ECS service health monitoring
- Load balancer metrics
- SNS notifications for deployments

## Environment Setup

### Prerequisites
- AWS Account
- GitHub Repository
- AWS CLI
- Docker
- .NET 9.0 SDK
- Node.js & npm

### Required AWS Resources
- VPC with public subnets
- ECR repository
- S3 bucket
- ECS cluster
- Application Load Balancer
- IAM roles and policies

## Deployment Workflow

### API Deployment
1. Code push triggers GitHub Actions.
2. Runs automated tests.
3. Builds Docker image.
4. Pushes to ECR.
5. Updates ECS task definition.
6. Monitors health checks.
7. Rolls back if needed.

### Website Deployment
1. Code push triggers GitHub Actions.
2. Builds static files.
3. Deploys to S3.

## Monitoring & Alerts

### Health Checks
- API endpoint monitoring
- ECS task health
- Load balancer target group health

### Alert Configurations
- Deployment success/failure notifications
- High error rate alerts
- Service health alerts
- Resource utilization alerts

## Rollback Procedures
- Automatic rollback on deployment failure
- Manual rollback available through AWS Console
- Previous task definition retention

## Security
- IAM role-based access
- Security groups configuration
- CORS policies

## Scalability
- ECS service auto-scaling
- Load balancer distribution
- Static content delivery through CDN capability
