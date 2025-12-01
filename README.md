# 🛡️ Práctica 11 – IA en Unity  
**Estudio: _Los Tres Mosqueteros_**

Repositorio oficial del proyecto desarrollado para la práctica grupal, donde implementamos un sistema de Inteligencia Artificial mediante una **máquina de estados** en Unity.

---

## 👥 Miembros del Estudio y Roles

| Integrante | Rol |
|-----------|------|
| **Mendez Mejía Aaron Alfredo** | 🧠 *El Alma de la Máquina* |
| **Galindo Beltrán Giancarlo Alexander** | 🏗️ *La Arquitectura del Cerebro* |
| **Robles Sanchez Britney Sheyla** | 🎯 *El Terreno de Caza* |

---

## 📌 Descripción del Hito

Este hito consistió en el desarrollo e integración de un sistema de IA basado en FSM (Finite State Machine), donde cada miembro del equipo asumió una parte clave del funcionamiento:

- Arquitectura de la máquina de estados  
- Lógica de transición entre patrullaje, persecución y búsqueda  
- Configuración de parámetros de comportamiento enemigo  
- Implementación y pruebas en el escenario  

---

## 💬 Reflexión del Estudio

### 🔄 Sinergia y Fricción

**Beneficios del trabajo en equipo:**

- Cada integrante se enfocó en una parte específica del sistema de IA, permitiendo avanzar con mayor rapidez y claridad.  
- La combinación de distintas perspectivas ayudó a detectar errores y mejorar la lógica entre estados.  

**Desafíos y soluciones:**

- La coordinación de cambios en el repositorio generó conflictos, especialmente en scripts como `AIController` y los estados.  
- Se resolvió aplicando un orden de trabajo, utilizando ramas para evitar sobrescrituras y revisando los cambios antes de fusionarlos.

---

## ⚙️ El Alma de la Máquina

El parámetro que más impacto tuvo en hacer que la IA se sintiera “viva” fue **`detectionRadius`**.

- Ajustarlo cambió la dinámica entre patrullar y perseguir.  
- Permitió que el enemigo reaccionara de forma más natural, con un equilibrio entre agresividad y pasividad.  
- La diferencia entre `detectionRadius` y `loseSightRadius` generó transiciones más creíbles, como si la IA realmente buscara o perdiera de vista al jugador.

