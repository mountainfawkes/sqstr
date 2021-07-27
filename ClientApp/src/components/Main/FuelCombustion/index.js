import fuels from "../../../Data/Fuels"

const fuelEstimateForm = ({ formCallback,
  estimateCallback,
  estimateVisibilityCallback }) => {
  function handleFuelInput(event) {
    event.preventDefault()
    const data = {
      type: event.target.type.value,
      fuel_source_type: event.target.fuel_source_type.value,
      fuel_source_unit: event.target.fuel_source_unit.value,
      fuel_source_value: parseInt(event.target.fuel_source_value.value, 10),
    }
    console.log(data)
    fetch(`http://localhost:5000/api/Attributes`, {
      method: `POST`,
      body: JSON.stringify(data),
      headers: {
        'Content-Type': `application/json`,
      },
    })
      .then(response => response.json())
      .then(data => estimateCallback(data))
      .then(data => console.log(data))

    formCallback(null)
    estimateVisibilityCallback(true)
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
          <input type='number' step='1' min='0' name='fuel_source_value' />
        </label>
        <button type='submit'>Estimate</button>
      </form>
    </div>
  )
}

export default fuelEstimateForm
