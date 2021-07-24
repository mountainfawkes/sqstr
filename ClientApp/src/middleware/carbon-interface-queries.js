export function handleElectricityInput(event) {
  event.preventDefault()
  const data = {
    type: event.target.type.value,
    electricity_unit: event.target.electricity_unit.value,
    electricity_value: event.target.electricity_value.value,
    country: event.target.country.value,
    state: event.target.state.value,
  }
  return data
}
