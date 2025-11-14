🛡️ Práctica 11 – IA en Unity

Estudio: Los Tres Mosqueteros

Repositorio oficial del proyecto desarrollado para la práctica grupal, donde implementamos un sistema de Inteligencia Artificial mediante una máquina de estados en Unity.

👥 Miembros del Estudio y Roles
Integrante	Rol
Mendez Mejía Aaron Alfredo	🧠 El Alma de la Máquina
Galindo Beltrán Giancarlo Alexander	🏗️ La Arquitectura del Cerebro
Robles Sanchez Britney Sheyla	🎯 El Terreno de Caza
📌 Descripción del Hito

Este hito consistió en el desarrollo e integración de un sistema de IA basado en FSM (Finite State Machine), donde cada miembro del equipo asumió una parte clave del funcionamiento:

Arquitectura de la máquina de estados

Lógica de transición entre patrullaje, persecución y búsqueda

Parámetros del comportamiento enemigo

Implementación y pruebas en el escenario

💬 Reflexión del Estudio
🔄 Sinergia y Fricción en el Equipo

Beneficios del trabajo en equipo:

Cada integrante se especializó en una parte distinta de la IA, lo que permitió avanzar de manera más rápida y organizada.

Las distintas perspectivas ayudaron a identificar errores de lógica y mejorar la coherencia entre estados.

La integración de ideas permitió equilibrar el comportamiento del enemigo para que se sintiera más realista.

Principales desafíos:

La coordinación de cambios en el repositorio generó conflictos, especialmente cuando varios editábamos scripts como AIController y los estados.

Se resolvió estableciendo un orden de trabajo, utilizando ramas (branches) y revisando los cambios antes de realizar merge para evitar sobrescrituras.

⚙️ “El Alma de la Máquina”

Durante la configuración del comportamiento de la IA, el parámetro con mayor impacto fue:

🎯 detectionRadius

Ajustarlo modificó totalmente la dinámica entre patrullar, detectar al jugador y comenzar la persecución.

Permitió lograr un nivel más natural de reacción:

Ni demasiado agresivo

Ni demasiado pasivo

La diferencia entre detectionRadius y loseSightRadius le dio realismo a las transiciones entre estados:

Parecía que el enemigo realmente buscaba o perdía de vista al jugador.
