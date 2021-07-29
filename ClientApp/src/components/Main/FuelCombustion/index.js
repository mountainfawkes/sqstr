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

  const contentStyles = {
    maxWidth: `45vw`,
    margin: `auto`,
    marginTop: `30px`,
    padding: `10px`,
    justifyContent: `center`,
    alignItems: `center`,
    backgroundColor: `#0A090C`,
  }

  const inputStyles = {
    display: `block`,
    margin: `5px`,
  }

  return (
    <div style={contentStyles}>
      <div style={{
        backgroundColor: `#131217`,
        color: `#F5F5F5`,
        padding: `15px`,
        fontFamily: `'Montserrat', sans-serif`,
      }}
      >
        <p>Because America runs on bituminous coal and jet fuel.</p>
        <form onSubmit={handleFuelInput}>
          <input type='hidden' name='type' value='fuel_combustion' />
          <div style={inputStyles}>
            <label htmlFor='fuel_source_type'>Type of fuel:
              <select
                name='fuel_source_type'
                style={{ margin: `0 0 0 10px` }}
              >
                {fuels.map(fuel =>
                  <option value={fuel.code}>{fuel.name}</option>)}
              </select>
            </label>
          </div>
          <div style={inputStyles}>
            <input
              type='hidden'
              name='fuel_source_unit'
              value='btu'
              style={{ margin: `0 0 0 10px` }}
            />
          </div>
          <div style={inputStyles}>
            <label htmlFor='fuel_source_value'>Amount used in BTU:
              <input
                type='number'
                step='1'
                min='0'
                name='fuel_source_value'
                style={{ margin: `0 0 0 10px` }}
              />
            </label>
          </div>
          <button type='submit' style={{ marginTop: `10px` }}>Estimate</button>
        </form>
      </div>
    </div>
  )
}

export default fuelEstimateForm
