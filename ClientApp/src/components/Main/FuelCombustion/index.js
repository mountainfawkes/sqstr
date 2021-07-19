import fuels from "../../../Data/Fuels"

const fuelEstimateForm = () => {
  function handleFuelInput(event) {
    event.preventDefault()
    console.log({
      type: event.target.type.value,
      fuel_source_type: event.target.fuel_source_type.value,
      fuel_source_unit: event.target.fuel_source_unit.value,
      fuel_source_value: event.target.fuel_source_value.value,
    })
  }
  return (
    <div>
      <h3>This is the fuel combustion form</h3>
      <form onSubmit={handleFuelInput}>
        <input type='hidden' name='type' value='fuel_combustion' />
        <label htmlFor='fuel_source_type'>Type of fuel:
          <select name='fuel_source_type'>
            {fuels.map(fuel =>
              <option value={fuel.code}>{fuel.name}</option>)}
          </select>
        </label>
        <input type='hidden' name='fuel_source_unit' value='btu' />
        <label htmlFor='fuel_source_value'>Amount used in BTU:
          <input type='number' step='0.1' min='0' name='fuel_source_value' />
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </div>
  )
}

export default fuelEstimateForm
