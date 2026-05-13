#Team DevStars - версия от Леши и Саши
# 🧁 бабуля Team



## 👥 Команда проекта

| | Участник | Роль |
|:-:|----------|------|
| 🧑‍💻 | **Сашенька** | QA, developer  |
| 🧪 | **Лёхич** | TechLead |



## 🃏 Карточки участников

<div align="center">

### 🚀 лешик
**Роль:** TechLead  
*Отвечает за архитектуру и техническую стратегию*



### ⚙️ саша
**Роль:** Developer  
*Пишет чистый код и реализует функционал*
**Роль:** QA  
*Тестирует и гарантирует качество продукта*

</div>



## 📁 Структура проекта
babylya/
├── .github/workflows/
│   └── check.yml          # CI: HTML validation + .NET build
├── backend/
│   └── TeamApi/           # ASP.NET Core Web API
│       ├── Program.cs
│       └── TeamApi.csproj
├── frontend/
│   ├── index.html         # Главная страница
│   └── style.css          # Стили карточек
└── README.md
## 🚀 Как запустить локально

### Требования

- .NET 8 SDK ([скачать](https://dotnet.microsoft.com/download))
- Любой современный браузер

### Запуск бэкенда

```bash
cd backend/TeamApi
dotnet run
```

API поднимется на `http://localhost:5000`. Терминал не закрывай — API работает, пока он открыт.

### Запуск фронтенда

Открой `frontend/index.html` двойным кликом в проводнике (или через Live Server в VS Code).

При запущенном API на странице появятся карточки участников.  
При остановленном API — сообщение «API недоступен. Запусти бэкенд!».

## 🔌 API

Все эндпоинты возвращают JSON.

| Метод | Путь | Описание |
|---|---|---|
| GET | `/api/team` | Список всех участников команды |
| GET | `/api/team/{name}` | Найти участника по имени (регистр не важен). 404 если не найден |
| GET | `/api/ping` | Healthcheck: статус, время сервера, имя команды |


## 🤖 CI/CD

При каждом Pull Request в `main` автоматически запускаются два job:

- **validate-html** — проверяет валидность `frontend/index.html` через `html-validate`
- **build-backend** — собирает C#-проект через `dotnet build`

Branch protection требует, чтобы оба job прошли зелёными — иначе кнопка Merge заблокирована.

## 📋 Процесс разработки

- `main` защищён: прямой push запрещён, только через Pull Request
- Каждая фича — в отдельной ветке (`feature/...`, `fix/...`)
- Каждый PR проходит code review с чеклистом
- Issues отслеживаются на Kanban-доске (Projects)
- Merge возможен только при зелёном CI

