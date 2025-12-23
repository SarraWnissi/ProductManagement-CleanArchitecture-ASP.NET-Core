# 🧼 Product Management API – Clean Architecture

Ce projet est une **API Web ASP.NET Core** qui implémente les principes de la **Clean Architecture** à travers un exemple concret de **système de gestion de produits**.

Il met en œuvre une architecture en couches bien séparées afin de garantir :
- une meilleure maintenabilité
- une forte testabilité
- une indépendance vis-à-vis des frameworks
- une évolutivité à long terme

---

## 🧠 Qu’est-ce que la Clean Architecture ?

La **Clean Architecture** est une philosophie de conception logicielle qui organise le code en couches distinctes avec des responsabilités clairement définies.

### Principes clés :
- Séparation des préoccupations
- Dépendances orientées vers le cœur du domaine
- Indépendance des frameworks et de l’infrastructure
- Faible couplage et forte cohésion

---

## 🏗️ Architecture du projet
ProductManagement
│
├── DomainLayer
│ └── Entities
│ └── Product.cs
│
├── ApplicationLayer
│ ├── DTOs
│ │ ├── ProductDTO.cs
│ │ ├── CreateProductDTO.cs
│ │ └── UpdateProductDTO.cs
│ ├── Interfaces
│ │ ├── Repositories
│ │ │ └── IProductRepository.cs
│ │ └── Services
│ │ └── IProductService.cs
│ └── Services
│ └── ProductService.cs
│
├── InfrastructureLayer
│ ├── Data
│ │ └── ApplicationDbContext.cs
│ └── Repositories
│ └── ProductRepository.cs
│
└── ProductsAPI
└── Controllers
└── ProductController.cs




---

## 📦 Description des couches

### 🔹 Domain Layer
- Cœur de l’application
- Contient les **entités métier** et les **règles de validation**
- Aucune dépendance externe

**Exemple :**
- Entité `Product`
- Validation du prix (> 0)
- Validation du stock (≥ 0)

---

### 🔹 Application Layer
- Contient la **logique métier applicative**
- Définit les **interfaces** (Repositories & Services)
- Utilise les **DTOs** pour échanger les données
- Ne dépend pas de l’infrastructure

---

### 🔹 Infrastructure Layer
- Implémente l’accès aux données
- Utilise **Entity Framework Core (Code First)**
- Contient :
  - `ApplicationDbContext`
  - Implémentations des repositories
  - Seed des données

---

### 🔹 Presentation Layer (API)
- Expose les endpoints HTTP
- Gère :
  - la validation des entrées
  - les réponses JSON
  - Swagger
- Ne contient aucune logique métier

---

## 🚀 Technologies utilisées

- ASP.NET Core Web API
- Entity Framework Core (Code First)
- SQL Server
- Clean Architecture
- Repository Pattern
- DTO Pattern
- Swagger / OpenAPI

---

## 🔌 Endpoints disponibles

| Méthode | Endpoint | Description |
|-------|---------|------------|
| GET | `/api/product` | Récupérer tous les produits |
| GET | `/api/product/{id}` | Récupérer un produit par ID |
| POST | `/api/product` | Ajouter un produit |
| PUT | `/api/product/{id}` | Modifier un produit |
| DELETE | `/api/product/{id}` | Supprimer un produit |

---

## 🗄️ Migration et Base de données

### Commandes EF Core :
```bash
add-migration dbcreate
update-database

📌 Le projet InfrastructureLayer doit être sélectionné comme projet cible de migration
📌 Le projet ProductsAPI doit être le projet de démarrage

✅ Avantages de cette architecture

✔ Code clair et structuré
✔ Facile à maintenir et à tester
✔ Indépendance vis-à-vis de la base de données
✔ Adapté aux projets professionnels et académiques

👩‍💻 Auteur

Sarra Wnissi

Projet académique – Clean Architecture avec ASP.NET Core

Le projet est structuré en **4 couches principales** :

