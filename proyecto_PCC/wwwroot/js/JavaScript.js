
    function seleccionarRegion(regionId, btn) {
        document.querySelectorAll('.panel-salario').forEach(p => p.classList.add('d-none'));
    document.getElementById('panel-' + regionId).classList.remove('d-none');

                document.querySelectorAll('.tab-salario').forEach(b => {
        b.classList.remove('btn-dotnet');
    b.classList.add('btn-soft');
                });
    btn.classList.remove('btn-soft');
    btn.classList.add('btn-dotnet');
            }

    function filtrarEmpresas() {
                const q = document.getElementById('filtroEmpresa').value.toLowerCase();
    const sector = document.getElementById('filtroSector').value.toLowerCase();

                document.querySelectorAll('.tarjeta-empresa').forEach(card => {
                    const texto = card.getAttribute('data-texto');
    const cardSector = card.getAttribute('data-sector');
    const coincideTexto = texto.includes(q);
    const coincideSector = sector === '' || cardSector.includes(sector);
    card.style.display = (coincideTexto && coincideSector) ? '' : 'none';
                });
            }

    async function evaluarEnServidor() {
                const anios = parseInt(document.getElementById('inputAnios').value) || 0;
    const nube = document.getElementById('checkNube').checked;
    const ingles = document.getElementById('checkIngles').checked;
    const token = document.querySelector('input[name="__RequestVerificationToken"]').value;

    const resp = await fetch('?handler=EvaluarPerfil', {
        method: 'POST',
    headers: {
        'Content-Type': 'application/json',
    'RequestVerificationToken': token
                    },
    body: JSON.stringify({aniosExperiencia: anios, sabeNube: nube, inglesAvanzado: ingles })
                });

    const data = await resp.json();
    document.getElementById('resNivel').textContent = data.nivel;
    document.getElementById('resSueldo').textContent = data.sueldoEstimado;
    document.getElementById('resDetalle').textContent = data.detalle;
            }
